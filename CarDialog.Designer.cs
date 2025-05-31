using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LashaMurgvaLominadzeShraieri.Final
{
    partial class CarDialog
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox ModelTextBox;
        private TextBox WeightTextBox;
        private TextBox SpeedTextBox;
        private Button DoneButton;
        private Label modelLbl;
        private Label weightLbl;
        private Label speedLbl;

        private void InitializeComponent()
        {
            ModelTextBox = new TextBox();
            WeightTextBox = new TextBox();
            SpeedTextBox = new TextBox();
            DoneButton = new Button();
            modelLbl = new Label();
            weightLbl = new Label();
            speedLbl = new Label();
            SuspendLayout();
            //
            // ModelTextBox
            //
            ModelTextBox.Location = new Point(12, 30);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(200, 23);
            ModelTextBox.TabIndex = 0;
            //
            // WeightTextBox
            //
            WeightTextBox.Location = new Point(12, 70);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(200, 23);
            WeightTextBox.TabIndex = 1;
            //
            // SpeedTextBox
            //
            SpeedTextBox.Location = new Point(12, 110);
            SpeedTextBox.Name = "SpeedTextBox";
            SpeedTextBox.Size = new Size(200, 23);
            SpeedTextBox.TabIndex = 2;
            //
            // DoneButton
            //
            DoneButton.Location = new Point(12, 150);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(200, 30);
            DoneButton.TabIndex = 3;
            DoneButton.Text = "Done";
            DoneButton.Click += DoneButton_Click;
            //
            // modelLbl
            //
            modelLbl.AutoSize = true;
            modelLbl.Location = new Point(12, 12);
            modelLbl.Name = "modelLbl";
            modelLbl.Size = new Size(41, 15);
            modelLbl.TabIndex = 4;
            modelLbl.Text = "Model";
            //
            // weightLbl
            //
            weightLbl.AutoSize = true;
            weightLbl.Location = new Point(12, 56);
            weightLbl.Name = "weightLbl";
            weightLbl.Size = new Size(45, 15);
            weightLbl.TabIndex = 5;
            weightLbl.Text = "Weight";
            //
            // speedLbl
            //
            speedLbl.AutoSize = true;
            speedLbl.Location = new Point(12, 96);
            speedLbl.Name = "speedLbl";
            speedLbl.Size = new Size(39, 15);
            speedLbl.TabIndex = 6;
            speedLbl.Text = "Speed";
            //
            // CarDialog
            //
            ClientSize = new Size(230, 200);
            Controls.Add(speedLbl);
            Controls.Add(weightLbl);
            Controls.Add(modelLbl);
            Controls.Add(ModelTextBox);
            Controls.Add(WeightTextBox);
            Controls.Add(SpeedTextBox);
            Controls.Add(DoneButton);
            Name = "CarDialog";
            Text = "Car Dialog";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
