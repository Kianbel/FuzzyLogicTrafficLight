using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyLogicTrafficLight
{
    // TODOs
    // 4. graph sa triangle 

    public partial class Form1 : Form
    {
        Lane l1 = new Lane();
        Lane l2 = new Lane();
        bool isRunning = false;
        bool isL1Running = true;
        bool isL2Running = false;

        bool isYellowLight = false;
        int yellowLane = 0; // either 1 = lane1 or 2 = lane2

        bool isL1WaitingTimeStarted = false;
        bool isL2WaitingTimeStarted = false;

        double l1WaitingTime = 0.0;
        double l2WaitingTime = 0.0;

        List<Car> carsLane1 = new List<Car>();
        List<Car> carsLane2 = new List<Car>();
        Timer animationTimer = new Timer();

        int l1Car = 0;
        int l2Car = 0;

        int l1CarsWaiting = 0;
        int l2CarsWaiting = 0;
        double standardTrafficLightTime = 15; // seconds

        public Form1()
        {
            InitializeComponent();

            // Setup animation timer for c
            animationTimer.Interval = 16;
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();

            SetL2WaitingTimeLabel(0);
            SetL1GoTimeLabel(0);
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int width = pictureBox1.ClientSize.Width;
            int height = pictureBox1.ClientSize.Height;

            int roadWidth = 75;

            float stopLineL1 = height / 2 + roadWidth / 2;
            float stopLineL2 = width / 2 - roadWidth / 2;

            float carSpacing = 15f;

            l1CarsWaiting = 0;
            l2CarsWaiting = 0;


            // Lane 1 cars
            for (int i = 0; i < carsLane1.Count; i++)
            {
                Car currentCar = carsLane1[i];
                bool canMove = true; // assume all cars are moving

                // 1. Stop at stop line
                if (!isL1Running && currentCar.Y >= stopLineL1)
                {
                    if (currentCar.Y - currentCar.Speed < stopLineL1)
                    {
                        canMove = false;
                        isL1WaitingTimeStarted = true;
                        isL2WaitingTimeStarted = false;
                    }
                }

                // 2. Dont bump car infront
                if (i > 0)
                {
                    Car carAhead = carsLane1[i - 1];
                    if (currentCar.Y - currentCar.Speed < carAhead.Y + carAhead.Height + carSpacing)
                    {
                        canMove = false;
                    }
                }

                if (currentCar.Y >= stopLineL1) l1CarsWaiting++;

                if (canMove) currentCar.Y -= currentCar.Speed;
            }

            // Lane 2 cars
            for (int i = 0; i < carsLane2.Count; i++)
            {
                Car currentCar = carsLane2[i];
                bool canMove = true;

                // 1. Stop at stop line
                if (!isL2Running && currentCar.X + currentCar.Width <= stopLineL2)
                {
                    if (currentCar.X + currentCar.Width + currentCar.Speed > stopLineL2)
                    {
                        canMove = false;
                        isL1WaitingTimeStarted = false;
                        isL2WaitingTimeStarted = true;
                    }
                }

                // 2. Dont bump car infront
                if (i > 0)
                {
                    Car carAhead = carsLane2[i - 1];
                    if (currentCar.X + currentCar.Width + currentCar.Speed + carSpacing > carAhead.X)
                    {
                        canMove = false;
                    }
                }

                if (currentCar.X + currentCar.Width <= stopLineL2) l2CarsWaiting++;

                if (canMove) currentCar.X += currentCar.Speed;
            }

            carsLane1.RemoveAll(car => car.Y < -50);
            carsLane2.RemoveAll(car => car.X > width + 50);

            Setl1CarsWaitingLabel(l1CarsWaiting);
            Setl2CarsWaitingLabel(l2CarsWaiting);

            pictureBox1.Invalidate(); // same as refresh
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int width = pictureBox1.ClientSize.Width;
            int height = pictureBox1.ClientSize.Height;

            Graphics g = e.Graphics;

            // Road and Pavement
            int roadWidth = 75;
            int pavementWidth = (int)(roadWidth * 1.5);

            Rectangle grass = new Rectangle(0, 0, width, height);
            g.FillRectangle(Brushes.Green, grass);
            Rectangle pavement1 = new Rectangle(width / 2 - pavementWidth / 2, 0, pavementWidth, height);
            Rectangle pavement2 = new Rectangle(0, height / 2 - pavementWidth / 2, width, pavementWidth);
            g.FillRectangle(Brushes.Gray, pavement1);
            g.FillRectangle(Brushes.Gray, pavement2);
            Rectangle road1 = new Rectangle(width / 2 - roadWidth / 2, 0, roadWidth, height);
            Rectangle road2 = new Rectangle(0, height / 2 - roadWidth / 2, width, roadWidth);
            g.FillRectangle(Brushes.Black, road1);
            g.FillRectangle(Brushes.Black, road2);
            g.DrawLine(Pens.White, width / 2, 0, width / 2, height);
            g.DrawLine(Pens.White, 0, height / 2, width, height / 2);
            Rectangle centerRoad = new Rectangle(width / 2 - roadWidth / 2, height / 2 - roadWidth / 2, roadWidth, roadWidth);
            g.FillRectangle(Brushes.Black, centerRoad);

            // Traffic Lights
            int baseWidth = 25;
            int baseHeight = baseWidth * 3;
            int baseMargin = baseWidth / 5;
            int lightWidth = baseWidth;
            int inbetweenLightPadding = baseWidth / 10;

            string redOn = "#ff0000";
            string redOff = "#450000";
            string greenOn = "#00d126";
            string greenOff = "#003b0b";
            string yellowOn = "#FFEE00";
            string yellowOff = "#3d3a00";

            string l1Red = "";
            string l1Green = "";
            string l1Yellow = "";
            string l2Red = "";
            string l2Green = "";
            string l2Yellow = "";

            if (isYellowLight)
            {
                if (yellowLane == 1)
                {
                    l1Red = redOff; l1Green = greenOff; l1Yellow = yellowOn;
                    l2Red = redOn; l2Green = greenOff; l2Yellow = yellowOff;
                }
                else
                {
                    l1Red = redOn; l1Green = greenOff; l1Yellow = yellowOff;
                    l2Red = redOff; l2Green = greenOff; l2Yellow = yellowOn;
                }
            }
            else if (isL1Running)
            {
                l1Red = redOff; l1Green = greenOn; l1Yellow = yellowOff;
                l2Red = redOn; l2Green = greenOff; l2Yellow = yellowOff;
            }
            else if (isL2Running)
            {
                l1Red = redOn; l1Green = greenOff; l1Yellow = yellowOff;
                l2Red = redOff; l2Green = greenOn; l2Yellow = yellowOff;
            }
            else
            {
                l1Red = redOn; l1Green = greenOff; l1Yellow = yellowOff;
                l2Red = redOn; l2Green = greenOff; l2Yellow = yellowOff;
            }

            Brush l1RedColorBrush = new SolidBrush(ColorTranslator.FromHtml(l1Red));
            Brush l1GreenColorBrush = new SolidBrush(ColorTranslator.FromHtml(l1Green));
            Brush l1YellowColorBrush = new SolidBrush(ColorTranslator.FromHtml(l1Yellow));

            Brush l2RedColorBrush = new SolidBrush(ColorTranslator.FromHtml(l2Red));
            Brush l2GreenColorBrush = new SolidBrush(ColorTranslator.FromHtml(l2Green));
            Brush l2YellowColorBrush = new SolidBrush(ColorTranslator.FromHtml(l2Yellow));

            int base1X = width / 2 + roadWidth;
            int base1Y = height / 2 + roadWidth;
            Rectangle base1 = new Rectangle(base1X, base1Y, baseWidth + baseMargin * 2, baseHeight + baseMargin * 2 + inbetweenLightPadding * 2);
            g.FillRectangle(Brushes.Black, base1);
            Rectangle red1 = new Rectangle(base1X + baseMargin, base1Y + baseMargin, lightWidth, lightWidth);
            Rectangle yellow1 = new Rectangle(base1X + baseMargin, base1Y + baseMargin + lightWidth + inbetweenLightPadding, lightWidth, lightWidth);
            g.FillEllipse(l1YellowColorBrush, yellow1);
            Rectangle green1 = new Rectangle(base1X + baseMargin, base1Y + baseMargin + lightWidth * 2 + inbetweenLightPadding * 2, lightWidth, lightWidth);

            int base2X = width / 2 - pavementWidth - roadWidth / 2 - 10;
            int base2Y = height / 2 - baseWidth * 4;
            Rectangle base2 = new Rectangle(base2X, base2Y, baseHeight + baseMargin * 2 + inbetweenLightPadding * 2, baseWidth + baseMargin * 2);
            g.FillRectangle(Brushes.Black, base2);
            Rectangle green2 = new Rectangle(base2X + baseMargin, base2Y + baseMargin, lightWidth, lightWidth);
            Rectangle yellow2 = new Rectangle(base2X + baseMargin + lightWidth + inbetweenLightPadding, base2Y + baseMargin, lightWidth, lightWidth);
            g.FillEllipse(l2YellowColorBrush, yellow2);
            Rectangle red2 = new Rectangle(base2X + baseMargin + lightWidth * 2 + inbetweenLightPadding * 2, base2Y + baseMargin, lightWidth, lightWidth);

            // Traffic lights on/off colors
            g.FillEllipse(l1RedColorBrush, red1);
            g.FillEllipse(l1GreenColorBrush, green1);
            g.FillEllipse(l2RedColorBrush, red2);
            g.FillEllipse(l2GreenColorBrush, green2);

            // --- DRAW CARS ---
            foreach (Car c in carsLane1) c.Draw(g);
            foreach (Car c in carsLane2) c.Draw(g);
        }

        private async Task TransitionLanesAsync()
        {
            isYellowLight = true;
            yellowLane = isL1Running ? 1 : 2;

            isL1Running = false;
            isL2Running = false;

            await Task.Delay(1000);

            if (yellowLane == 1)
            {
                isL2Running = true;
            }
            else
            {
                isL1Running = true;
            }

            l1WaitingTime = 0;
            l2WaitingTime = 0;
            isYellowLight = false;
        }

        double initialWaitingTime;
        int initialCarsQueued;

        private async void button1_Click(object sender, EventArgs e)
        {
            startRandomizedCarButton.Enabled = false;
            startInputButton.Enabled = false;

            l1Car = 6;
            isL1Running = true;
            isL2Running = false;
            double timeExtension = l1.GetTimeExtension(l1WaitingTime, l1Car); // seconds

            int timeCounter = 0;
            Random random = new Random();
            int width = pictureBox1.ClientSize.Width;
            int height = pictureBox1.ClientSize.Height;
            int roadWidth = 75;

            int carWidth = 20;
            int carHeight = 35;
            int carSpawnMargin = 50;

            int spawnCarChance = 4;

            isRunning = true;
            while (isRunning)
            {
                if (isL1WaitingTimeStarted)
                {
                    l1WaitingTime++;
                    SetL1WaitingTimeLabel(l1WaitingTime);
                }
                if (isL2WaitingTimeStarted)
                {
                    l2WaitingTime++;
                    SetL2WaitingTimeLabel(l2WaitingTime);
                }

                if (isL1Running)
                {
                    if (timeCounter < standardTrafficLightTime + timeExtension)
                    {
                        timeCounter++;
                        SetL1GoTimeLabel(standardTrafficLightTime + timeExtension - timeCounter);
                        SetL1WaitingTimeLabel(0);

                        if (random.Next(10) < spawnCarChance)
                        {
                            l1Car++;
                            carsLane1.Add(new Car
                            {
                                X = width / 2 + (roadWidth / 4) - carWidth / 2,
                                Y = height + carSpawnMargin,
                                Width = carWidth,
                                Height = carHeight,
                                Color = Color.Blue
                            });
                        }
                        if (random.Next(10) < spawnCarChance)
                        {
                            l2Car++;
                            carsLane2.Add(new Car
                            {
                                X = -carSpawnMargin,
                                Y = height / 2 + (roadWidth / 4) - carWidth / 2,
                                Width = carHeight,
                                Height = carWidth,
                                Color = Color.Red
                            });
                        }

                        if (l1Car > 0)
                        {
                            if (timeCounter % 2 == 0) l1Car--;
                        }
                    }
                    else
                    {
                        timeCounter = 0;
                        Console.Write("L2: ");
                        timeExtension = l2.GetTimeExtension(l2WaitingTime, l2CarsWaiting);

                        l2WaitingTime = standardTrafficLightTime + timeExtension;

                        await TransitionLanesAsync();
                        SetL1WaitingTimeLabel(0);
                        SetL1GoTimeLabel(0);
                    }
                }
                else if (isL2Running)
                {
                    if (timeCounter < standardTrafficLightTime + timeExtension)
                    {
                        timeCounter++;
                        SetL2GoTimeLabel(standardTrafficLightTime + timeExtension - timeCounter);
                        SetL2WaitingTimeLabel(0);

                        if (random.Next(10) < spawnCarChance)
                        {
                            l1Car++;
                            // Spawn a vertical car at the bottom
                            carsLane1.Add(new Car
                            {
                                X = width / 2 + (roadWidth / 4) - 10,
                                Y = height + carSpawnMargin,
                                Width = 20,
                                Height = 35,
                                Color = Color.Blue
                            });
                        }
                        if (random.Next(10) < spawnCarChance)
                        {
                            l2Car++;
                            carsLane2.Add(new Car
                            {
                                X = -carSpawnMargin,
                                Y = height / 2 + (roadWidth / 4) - carWidth / 2,
                                Width = carHeight,
                                Height = carWidth,
                                Color = Color.Red
                            });
                        }

                        if (l2Car > 0)
                        {
                            if (timeCounter % 2 == 0) l2Car--;
                        }
                    }
                    else
                    {
                        timeCounter = 0;
                        Console.Write("L1: ");
                        timeExtension = l1.GetTimeExtension(l1WaitingTime, l1CarsWaiting);

                        l1WaitingTime = standardTrafficLightTime + timeExtension;

                        await TransitionLanesAsync();
                        SetL2WaitingTimeLabel(0);
                        SetL2GoTimeLabel(0);
                    }
                }

                await Task.Delay(500);
            }
        }



        private async void startInputButton_Click(object sender, EventArgs e)
        {
            startInputButton.Enabled = false;
            startRandomizedCarButton.Enabled = false;

            isL1Running = true;
            isL2Running = false;
            double timeExtension = l1.GetTimeExtension(initialWaitingTime, initialCarsQueued); // seconds

            int timeCounter = 0;

            isRunning = true;
            while (isRunning)
            {
                if (timeCounter < standardTrafficLightTime + timeExtension)
                {
                    timeCounter++;
                    SetL1GoTimeLabel(standardTrafficLightTime + timeExtension - timeCounter);
                    SetL1WaitingTimeLabel(0);

                }
                else break;

                await Task.Delay(500);

            }

        }

        private void setInputButton_Click(object sender, EventArgs e)
        {
            isL1Running = false;

            initialWaitingTime = Convert.ToDouble(waitingTimeInput.Value);
            initialCarsQueued = Convert.ToInt32(carsQueuedInput.Value);

            SetL1WaitingTimeLabel(initialWaitingTime);
            Setl1CarsWaitingLabel(initialCarsQueued);

            for (int i = 0; i < initialCarsQueued; i++)
            {
                int width = pictureBox1.ClientSize.Width;
                int height = pictureBox1.ClientSize.Height;
                int roadWidth = 75;

                int carWidth = 20;
                int carHeight = 35;
                int carSpawnMargin = 50;

                carsLane1.Add(new Car
                {
                    X = width / 2 + (roadWidth / 4) - carWidth / 2,
                    Y = height + carSpawnMargin,
                    Width = carWidth,
                    Height = carHeight,
                    Color = Color.Blue
                });
            }
        }

        private void stopAllButton_Click(object sender, EventArgs e)
        {
            isRunning = false;
            startRandomizedCarButton.Enabled = true;
            startInputButton.Enabled = true;

            l1Car = 0;
            l2Car = 0;

            carsLane1.Clear();
            carsLane2.Clear();

            l1WaitingTime = 0;
            l2WaitingTime = 0;

            SetL1WaitingTimeLabel(0);
            SetL2WaitingTimeLabel(0);
            SetL1GoTimeLabel(0);
            SetL2GoTimeLabel(0);
            Setl1CarsWaitingLabel(0);
            Setl2CarsWaitingLabel(0);
        }

        private void SetL1WaitingTimeLabel(double time)
        {
            l1WaitingTimeLabel.Text = $"Waiting Time: {time:F2}s";
        }
        private void SetL2WaitingTimeLabel(double time)
        {
            l2WaitingTimeLabel.Text = $"Waiting Time: {time:F2}s";
        }
        private void SetL1GoTimeLabel(double time)
        {
            l1GoTimeLabel.Text = $"Go Time Remaining: {time:F2}s";
        }
        private void SetL2GoTimeLabel(double time)
        {
            l2GoTimeLabel.Text = $"Go Time Remaining: {time:F2}s";
        }
        private void Setl1CarsWaitingLabel(int n)
        {
            l1CarsWaitingLabel.Text = $"Cars Waiting: {n}";
        }
        private void Setl2CarsWaitingLabel(int n)
        {
            l2CarsWaitingLabel.Text = $"Cars Waiting: {n}";
        }
    }

    public class Car
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Speed { get; set; } = 3f; // Adjust this number for faster/slower cars
        public Color Color { get; set; }

        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color), X, Y, Width, Height);
        }
    }

    public class Lane
    {
        public double GetTimeExtension(double waitingTime, int carQueue)
        {
            Console.Write($"wait:{waitingTime} | cars:{carQueue} : +");

            double briefWaitingTime = TriangularMembership(waitingTime, 20, 35, 50); // 
            double moderateWaitingTime = TriangularMembership(waitingTime, 40, 60, 80);
            double prolongedWaitingTime = TriangularMembership(waitingTime, 75, 97.5, 120);

            double shortCarQueue = TriangularMembership(carQueue, 10, 15, 20);
            double mediumCarQueue = TriangularMembership(carQueue, 18, 24, 30);
            double longCarQueue = TriangularMembership(carQueue, 25, 35, 45);

            double highRule = Math.Max(prolongedWaitingTime, longCarQueue);
            double moderateRule = (moderateWaitingTime + mediumCarQueue) / 2;
            double lowRule = Math.Min(briefWaitingTime, shortCarQueue);

            double cShort = 10.0;
            double cMedium = 15.0;
            double cLong = 20.0;
            double numerator = (lowRule * cShort) + (moderateRule * cMedium) + (highRule * cLong);
            double denominator = highRule + moderateRule + lowRule;
            double centroid = 0.0;
            if (denominator > 0)
            {
                centroid = numerator / denominator;
            }
            Console.Write(centroid + $" {centroid + 15}\n------------------\n");
            return centroid;
        }

        private double TriangularMembership(double x, double a, double b, double c)
        {
            if (x <= a || x >= c)
                return 0.0;
            if (x == b)
                return 1.0;
            if (x > a && x < b)
                return (x - a) / (b - a);
            return (c - x) / (c - b);
        }
    }

}