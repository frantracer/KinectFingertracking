using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FingerTracking
{
    public partial class MainWindow : Form
    {
        KinectTracker kinectController;

        public MainWindow()
        {
            InitializeComponent();
            kinectController = new KinectTracker();

            kinectController.setEventColorReady(drawColorImage);

            if (kinectController.isConnected())
            {
                kinectController.start();

                // Show the default values of the Kinect settings
                double initialTheta = kinectController.settings.theta / (Math.PI / 180);
                thetaTextBox.Text = initialTheta.ToString();
                thetaTrackBar.Value = (int) initialTheta;

                int initialK = kinectController.settings.k;
                kTextBox.Text = initialK.ToString();
                kTrackBar.Value = initialK;

                float initialNearSpace = kinectController.settings.nearSpacePerc;
                NearSpaceTextBox.Text = initialNearSpace.ToString();
                NearSpaceTrackBar.Value = (int) (initialNearSpace * 100);

                textMarginLeft.Text = kinectController.settings.marginLeftPerc.ToString();
                textMarginRight.Text = kinectController.settings.marginRightPerc.ToString();
                textMarginTop.Text = kinectController.settings.marginTopPerc.ToString();
                textMarginBot.Text = kinectController.settings.marginBotPerc.ToString();

                smoothTextBox.Text = kinectController.settings.smoothingIterations.ToString();
                smoothTrackBar.Value = kinectController.settings.smoothingIterations;

                boxReductionTextBox.Text = ((int)(kinectController.settings.containerBoxReduction * 100)).ToString();
                boxReductionTrackBar.Value = (int)(kinectController.settings.containerBoxReduction * 100);
            }
            else
            {
                // Show an error
                Console.WriteLine("There is not any Kinect device connected.\nConnect it and restart the application.\n");
            }

        }

        // Show the color image in both image elements
        private void drawColorImage()
        {
            colorImage.Image = kinectController.getColorImage();
            trackingImage.Image = kinectController.getColorImage();
        }

        // Show the color and tracked images in the image elements
        private void drawDepthImage()
        {
            colorImage.Image = kinectController.getColorImage();
            trackingImage.Image = kinectController.getDepthImage();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            // Do nothing after the depth image is ready
            kinectController.clearEventDepthReady();

            // Show the image after the color image is ready
            KinectTracker.afterReady a = drawColorImage;
            kinectController.setEventColorReady(a);
        }

        private void depthButton_Click(object sender, EventArgs e)
        {
            // Do nothing after the Camera color image is ready
            kinectController.clearEventColorReady();

            // After the depth image is ready and the tracking done
            KinectTracker.afterReady a = drawDepthImage; // Show the depth image
            a = a + showNumberFingers; // Show the number of fingers
            kinectController.setEventDepthReady(a);
        }

        private void thetaTrackBar_Scroll(object sender, EventArgs e)
        {
            kinectController.settings.theta = thetaTrackBar.Value * (Math.PI / 180);
            thetaTextBox.Text = thetaTrackBar.Value.ToString();
        }

        private void kTrackBar_Scroll(object sender, EventArgs e)
        {
            kinectController.settings.k = kTrackBar.Value;
            kTextBox.Text = kTrackBar.Value.ToString();
        }

        private void showNumberFingers()
        {
            if (kinectController.hands.Count > 0)
            {
                if (kinectController.hands.Count > 0)
                    fingersTextBox1.Text = kinectController.hands[0].fingertips.Count.ToString();
                if (kinectController.hands.Count > 1)
                    fingersTextBox2.Text = kinectController.hands[1].fingertips.Count.ToString();
            }
        }

        private void NearSpaceTrackBar_Scroll(object sender, EventArgs e)
        {
            if (AbsoluteCheckBox.Checked)
            {
                kinectController.settings.absoluteSpace = NearSpaceTrackBar.Value * 50;
                NearSpaceTextBox.Text = kinectController.settings.absoluteSpace.ToString();
            }
            else
            {
                kinectController.settings.absoluteSpace = -1;
                kinectController.settings.nearSpacePerc = NearSpaceTrackBar.Value / 100.0f;
                NearSpaceTextBox.Text = kinectController.settings.nearSpacePerc.ToString();
            }
        }

        private void Smooth_Scroll(object sender, EventArgs e)
        {
            kinectController.settings.smoothingIterations = smoothTrackBar.Value;
            smoothTextBox.Text = smoothTrackBar.Value.ToString();
        }

        private void BoxReduction_Scroll(object sender, EventArgs e)
        {
            kinectController.settings.containerBoxReduction = (smoothTrackBar.Value / 100.0f);
            smoothTextBox.Text = smoothTrackBar.Value.ToString();
        }

        private void marginsChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            float perc = 0;
            if (!box.Text.Equals(""))
            {
                try
                {
                    perc = Convert.ToSingle(box.Text);
                }
                catch (Exception exception)
                {
                    perc = 0;
                }
            }
            perc = Math.Min(perc, 30);
            String percStr = perc.ToString();

            if (checkSameMargins.Checked)
            {
                kinectController.settings.marginLeftPerc = perc;
                textMarginLeft.Text = percStr;
                kinectController.settings.marginRightPerc = perc;
                textMarginRight.Text = percStr;
                kinectController.settings.marginTopPerc = perc;
                textMarginTop.Text = percStr;
                kinectController.settings.marginBotPerc = perc;
                textMarginBot.Text = percStr;
            }
            else
            {
                if (box.Name.Equals("textMarginLeft"))
                {
                    kinectController.settings.marginLeftPerc = perc;
                    textMarginLeft.Text = percStr;
                }
                else if (box.Name.Equals("textMarginRight"))
                {
                    kinectController.settings.marginRightPerc = perc;
                    textMarginRight.Text = percStr;
                }
                else if (box.Name.Equals("textMarginTop"))
                {
                    kinectController.settings.marginTopPerc = perc;
                    textMarginTop.Text = percStr;
                }
                else if (box.Name.Equals("textMarginBot"))
                {
                    kinectController.settings.marginBotPerc = perc;
                    textMarginBot.Text = percStr;
                }
            }
        }
    }
}
