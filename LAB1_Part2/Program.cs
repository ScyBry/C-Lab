namespace LAB1_Part2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new CylinderForm());
            Application.Run(new TriangleForm());
            Application.Run(new RingForm());
            Application.Run(new SquareForm());
            Application.Run(new ScalarProductForm());
            Application.Run(new SphereVolumeForm());

        }
    }


    public class SphereVolumeForm : Form
    {
        private Label labelTitle, labelRadius, labelResult;
        private TextBox textBoxRadius, textBoxResult;
        private Button buttonCalculate;

        public SphereVolumeForm()
        {
            this.Text = "Расчет объема шара";
            this.Width = 350;
            this.Height = 250;

            labelTitle = new Label() { Text = "Объем шара", Top = 20, Left = 120, Width = 200 };

            labelRadius = new Label() { Text = "Радиус шара (R):", Top = 60, Left = 20 };
            textBoxRadius = new TextBox() { Top = 60, Left = 150, Width = 50 };

            buttonCalculate = new Button() { Text = "Рассчитать", Top = 100, Left = 150, Width = 100 };
            buttonCalculate.Click += ButtonCalculate_Click;

            labelResult = new Label() { Text = "Результат:", Top = 140, Left = 20 };
            textBoxResult = new TextBox() { Top = 140, Left = 100, Width = 220, ReadOnly = true };

            Controls.Add(labelTitle);
            Controls.Add(labelRadius);
            Controls.Add(textBoxRadius);
            Controls.Add(buttonCalculate);
            Controls.Add(labelResult);
            Controls.Add(textBoxResult);
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                double radius = Convert.ToDouble(textBoxRadius.Text);


                double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);


                textBoxResult.Text = volume.ToString("F2");
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите корректное числовое значение для радиуса.");
            }
        }
    }


    public class SphereSurfaceAreaForm : Form
    {
        private Label labelTitle, labelRadius, labelResult;
        private TextBox textBoxRadius, textBoxResult;
        private Button buttonCalculate;

        public SphereSurfaceAreaForm()
        {
            this.Text = "Расчет площади поверхности шара";
            this.Width = 350;
            this.Height = 250;

            labelTitle = new Label() { Text = "Площадь поверхности шара", Top = 20, Left = 100, Width = 200 };

            labelRadius = new Label() { Text = "Радиус шара (R):", Top = 60, Left = 20 };
            textBoxRadius = new TextBox() { Top = 60, Left = 150, Width = 50 };

            buttonCalculate = new Button() { Text = "Рассчитать", Top = 100, Left = 150, Width = 100 };
            buttonCalculate.Click += ButtonCalculate_Click;

            labelResult = new Label() { Text = "Результат:", Top = 140, Left = 20 };
            textBoxResult = new TextBox() { Top = 140, Left = 100, Width = 220, ReadOnly = true };

            Controls.Add(labelTitle);
            Controls.Add(labelRadius);
            Controls.Add(textBoxRadius);
            Controls.Add(buttonCalculate);
            Controls.Add(labelResult);
            Controls.Add(textBoxResult);
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                double radius = Convert.ToDouble(textBoxRadius.Text);


                double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);

                textBoxResult.Text = surfaceArea.ToString("F2");
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите корректное числовое значение для радиуса.");
            }
        }
    }

    public class ScalarProductForm : Form
    {
        private Label labelTitle, labelVector1, labelVector2, labelResult;
        private TextBox textBoxX1, textBoxY1, textBoxZ1, textBoxX2, textBoxY2, textBoxZ2, textBoxResult;
        private Button buttonCalculate;

        public ScalarProductForm()
        {
            this.Text = "Расчет скалярного произведения";
            this.Width = 350;
            this.Height = 300;

            labelTitle = new Label() { Text = "Скалярное произведение двух векторов", Top = 20, Left = 90, Width = 200 };

            labelVector1 = new Label() { Text = "Вектор 1 (x1, y1, z1):", Top = 60, Left = 20 };
            textBoxX1 = new TextBox() { Top = 60, Left = 150, Width = 50 };
            textBoxY1 = new TextBox() { Top = 60, Left = 210, Width = 50 };
            textBoxZ1 = new TextBox() { Top = 60, Left = 270, Width = 50 };

            labelVector2 = new Label() { Text = "Вектор 2 (x2, y2, z2):", Top = 100, Left = 20 };
            textBoxX2 = new TextBox() { Top = 100, Left = 150, Width = 50 };
            textBoxY2 = new TextBox() { Top = 100, Left = 210, Width = 50 };
            textBoxZ2 = new TextBox() { Top = 100, Left = 270, Width = 50 };

            buttonCalculate = new Button() { Text = "Рассчитать", Top = 140, Left = 150, Width = 100 };
            buttonCalculate.Click += ButtonCalculate_Click;

            labelResult = new Label() { Text = "Результат:", Top = 180, Left = 20 };
            textBoxResult = new TextBox() { Top = 180, Left = 100, Width = 220, ReadOnly = true };

            Controls.Add(labelTitle);
            Controls.Add(labelVector1);
            Controls.Add(textBoxX1);
            Controls.Add(textBoxY1);
            Controls.Add(textBoxZ1);
            Controls.Add(labelVector2);
            Controls.Add(textBoxX2);
            Controls.Add(textBoxY2);
            Controls.Add(textBoxZ2);
            Controls.Add(buttonCalculate);
            Controls.Add(labelResult);
            Controls.Add(textBoxResult);
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                double x1 = Convert.ToDouble(textBoxX1.Text);
                double y1 = Convert.ToDouble(textBoxY1.Text);
                double z1 = Convert.ToDouble(textBoxZ1.Text);
                double x2 = Convert.ToDouble(textBoxX2.Text);
                double y2 = Convert.ToDouble(textBoxY2.Text);
                double z2 = Convert.ToDouble(textBoxZ2.Text);


                double scalarProduct = (x1 * x2) + (y1 * y2) + (z1 * z2);


                textBoxResult.Text = scalarProduct.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения в поля.");
            }
        }
    }

    public class SquareForm : Form
    {
        private Label labelTitle, labelValue, labelArea;
        private TrackBar trackBarSide;
        private TextBox textBoxArea;

        public SquareForm()
        {
            this.Text = "Площадь квадрата";
            this.Width = 350;
            this.Height = 250;

            labelTitle = new Label() { Text = "Длина стороны квадрата:", Top = 20, Left = 20, Width = 200 };
            trackBarSide = new TrackBar() { Top = 50, Left = 20, Width = 280, Minimum = 1, Maximum = 50, TickFrequency = 1 };
            trackBarSide.ValueChanged += TrackBarSide_ValueChanged;

            labelValue = new Label() { Text = "Текущая длина: 1", Top = 90, Left = 20, Width = 200 };
            labelArea = new Label() { Text = "Площадь:", Top = 130, Left = 20, Width = 100 };
            textBoxArea = new TextBox() { Top = 130, Left = 100, Width = 100, ReadOnly = true };

            Controls.Add(labelTitle);
            Controls.Add(trackBarSide);
            Controls.Add(labelValue);
            Controls.Add(labelArea);
            Controls.Add(textBoxArea);

            UpdateArea();
        }

        private void TrackBarSide_ValueChanged(object sender, EventArgs e)
        {
            labelValue.Text = $"Текущая длина: {trackBarSide.Value}";
            UpdateArea();
        }

        private void UpdateArea()
        {
            int side = trackBarSide.Value;
            int area = side * side;
            textBoxArea.Text = area.ToString();
        }
    }

    public class RingForm : Form
    {
        private Label labelR1, labelR2, labelArea;
        private TextBox textBoxR1, textBoxR2, textBoxArea;
        private Button buttonCalculate;

        public RingForm()
        {
            this.Text = "Площадь кольца";
            this.Width = 350;
            this.Height = 250;

            labelR1 = new Label() { Text = "Внешний радиус (R1):", Top = 20, Left = 20, Width = 150 };
            textBoxR1 = new TextBox() { Top = 20, Left = 180, Width = 120, TextAlign = HorizontalAlignment.Center };

            labelR2 = new Label() { Text = "Внутренний радиус (R2):", Top = 60, Left = 20, Width = 150 };
            textBoxR2 = new TextBox() { Top = 60, Left = 180, Width = 120, TextAlign = HorizontalAlignment.Center };

            buttonCalculate = new Button() { Text = "Рассчитать", Top = 100, Left = 180, Width = 120 };
            buttonCalculate.Click += ButtonCalculate_Click;

            labelArea = new Label() { Text = "Площадь кольца:", Top = 140, Left = 20, Width = 150 };
            textBoxArea = new TextBox() { Top = 140, Left = 180, Width = 120, ReadOnly = true };

            Controls.Add(labelR1);
            Controls.Add(textBoxR1);
            Controls.Add(labelR2);
            Controls.Add(textBoxR2);
            Controls.Add(buttonCalculate);
            Controls.Add(labelArea);
            Controls.Add(textBoxArea);
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBoxR1.Text);
                double R2 = Convert.ToDouble(textBoxR2.Text);

                if (R1 <= 0 || R2 <= 0 || R1 <= R2)
                {
                    MessageBox.Show("Убедитесь, что R1 > R2 и оба радиуса положительные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double area = Math.PI * (R1 * R1 - R2 * R2);
                textBoxArea.Text = area.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class TriangleForm : Form
    {
        private Label labelA, labelB, labelC, labelArea, labelPerimeter, labelHypotenuse;
        private TextBox textBoxA, textBoxB, textBoxC, textBoxArea, textBoxPerimeter, textBoxHypotenuse;
        private Button buttonCalculate;

        public TriangleForm()
        {
            this.Text = "Прямоугольный треугольник";
            this.Width = 400;
            this.Height = 350;

            labelA = new Label() { Text = "Сторона a:", Top = 20, Left = 20, Width = 100 };
            textBoxA = new TextBox() { Top = 20, Left = 130, Width = 200, TextAlign = HorizontalAlignment.Center };

            labelB = new Label() { Text = "Сторона b:", Top = 60, Left = 20, Width = 100 };
            textBoxB = new TextBox() { Top = 60, Left = 130, Width = 200, TextAlign = HorizontalAlignment.Center };

            labelC = new Label() { Text = "Сторона c:", Top = 100, Left = 20, Width = 100 };
            textBoxC = new TextBox() { Top = 100, Left = 130, Width = 200, TextAlign = HorizontalAlignment.Center };

            buttonCalculate = new Button() { Text = "Рассчитать", Top = 140, Left = 130, Width = 200 };
            buttonCalculate.Click += ButtonCalculate_Click;

            labelArea = new Label() { Text = "Площадь:", Top = 180, Left = 20, Width = 100 };
            textBoxArea = new TextBox() { Top = 180, Left = 130, Width = 200, ReadOnly = true };

            labelPerimeter = new Label() { Text = "Периметр:", Top = 220, Left = 20, Width = 100 };
            textBoxPerimeter = new TextBox() { Top = 220, Left = 130, Width = 200, ReadOnly = true };

            labelHypotenuse = new Label() { Text = "Гипотенуза:", Top = 260, Left = 20, Width = 100 };
            textBoxHypotenuse = new TextBox() { Top = 260, Left = 130, Width = 200, ReadOnly = true };

            Controls.Add(labelA);
            Controls.Add(textBoxA);
            Controls.Add(labelB);
            Controls.Add(textBoxB);
            Controls.Add(labelC);
            Controls.Add(textBoxC);
            Controls.Add(buttonCalculate);
            Controls.Add(labelArea);
            Controls.Add(textBoxArea);
            Controls.Add(labelPerimeter);
            Controls.Add(textBoxPerimeter);
            Controls.Add(labelHypotenuse);
            Controls.Add(textBoxHypotenuse);
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double c = Convert.ToDouble(textBoxC.Text);


                double hypotenuse = Math.Max(c, Math.Max(a, b));


                bool isRight = true;
                if (Math.Abs(c * c - (a * a + b * b)) < 0.001) isRight = true;
                if (Math.Abs(a * a - (b * b + c * c)) < 0.001) isRight = true;
                if (Math.Abs(b * b - (a * a + c * c)) < 0.001) isRight = true;

                if (!isRight)
                {
                    MessageBox.Show("Треугольник не является прямоугольным.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double area = (a * b) / 2; // только если a и b — катеты
                double perimeter = a + b + c;

                textBoxArea.Text = area.ToString("F2");
                textBoxPerimeter.Text = perimeter.ToString("F2");
                textBoxHypotenuse.Text = hypotenuse.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Введите корректные числовые значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class CylinderForm : Form
    {
        private Label labelRadius, labelHeight, labelBaseArea, labelVolume, labelSurfaceArea;
        private TextBox textBoxRadius, textBoxHeight, textBoxBaseArea, textBoxVolume, textBoxSurfaceArea;
        private Button buttonCalculate;

        public CylinderForm()
        {
            this.Text = "Характеристики цилиндра";
            this.Width = 400;
            this.Height = 350;

            labelRadius = new Label() { Text = "Радиус R:", Top = 20, Left = 20, Width = 100 };
            textBoxRadius = new TextBox() { Top = 20, Left = 130, Width = 200, TextAlign = HorizontalAlignment.Center };

            labelHeight = new Label() { Text = "Высота H:", Top = 60, Left = 20, Width = 100 };
            textBoxHeight = new TextBox() { Top = 60, Left = 130, Width = 200, TextAlign = HorizontalAlignment.Center };

            buttonCalculate = new Button() { Text = "Рассчитать", Top = 100, Left = 130, Width = 200 };
            buttonCalculate.Click += ButtonCalculate_Click;

            labelBaseArea = new Label() { Text = "Площадь основания:", Top = 150, Left = 20, Width = 150 };
            textBoxBaseArea = new TextBox() { Top = 150, Left = 180, Width = 150, ReadOnly = true };

            labelVolume = new Label() { Text = "Объем цилиндра:", Top = 190, Left = 20, Width = 150 };
            textBoxVolume = new TextBox() { Top = 190, Left = 180, Width = 150, ReadOnly = true };

            labelSurfaceArea = new Label() { Text = "Площадь полной поверхности:", Top = 230, Left = 20, Width = 200 };
            textBoxSurfaceArea = new TextBox() { Top = 230, Left = 230, Width = 100, ReadOnly = true };

            this.Controls.Add(labelRadius);
            this.Controls.Add(textBoxRadius);
            this.Controls.Add(labelHeight);
            this.Controls.Add(textBoxHeight);
            this.Controls.Add(buttonCalculate);
            this.Controls.Add(labelBaseArea);
            this.Controls.Add(textBoxBaseArea);
            this.Controls.Add(labelVolume);
            this.Controls.Add(textBoxVolume);
            this.Controls.Add(labelSurfaceArea);
            this.Controls.Add(textBoxSurfaceArea);
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(textBoxRadius.Text);
                double h = Convert.ToDouble(textBoxHeight.Text);

                double baseArea = Math.PI * r * r;
                double volume = baseArea * h;
                double surfaceArea = 2 * Math.PI * r * (r + h);

                textBoxBaseArea.Text = baseArea.ToString("F2");
                textBoxVolume.Text = volume.ToString("F2");
                textBoxSurfaceArea.Text = surfaceArea.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Введите корректные значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
