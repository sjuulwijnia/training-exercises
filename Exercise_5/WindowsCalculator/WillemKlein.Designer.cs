namespace WindowsCalculator
{
    partial class WillemKlein
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelA = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.NumericUpDown();
            this.inputB = new System.Windows.Forms.NumericUpDown();
            this.labelB = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.plusEquals = new System.Windows.Forms.Label();
            this.plusResult = new System.Windows.Forms.Label();
            this.minusResult = new System.Windows.Forms.Label();
            this.minusEquals = new System.Windows.Forms.Label();
            this.minusButton = new System.Windows.Forms.Button();
            this.divideResult = new System.Windows.Forms.Label();
            this.divideEquals = new System.Windows.Forms.Label();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyResult = new System.Windows.Forms.Label();
            this.multiplyEquals = new System.Windows.Forms.Label();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.powerResult = new System.Windows.Forms.Label();
            this.powerEquals = new System.Windows.Forms.Label();
            this.powerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).BeginInit();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(20, 14);
            this.labelA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(21, 20);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A";
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(153, 14);
            this.inputA.Margin = new System.Windows.Forms.Padding(5);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(200, 26);
            this.inputA.TabIndex = 1;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(153, 54);
            this.inputB.Margin = new System.Windows.Forms.Padding(5);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(200, 26);
            this.inputB.TabIndex = 3;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(20, 54);
            this.labelB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(21, 20);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "B";
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(363, 52);
            this.plusButton.Margin = new System.Windows.Forms.Padding(5);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(37, 34);
            this.plusButton.TabIndex = 4;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // plusEquals
            // 
            this.plusEquals.AutoSize = true;
            this.plusEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusEquals.Location = new System.Drawing.Point(410, 60);
            this.plusEquals.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.plusEquals.Name = "plusEquals";
            this.plusEquals.Size = new System.Drawing.Size(19, 20);
            this.plusEquals.TabIndex = 5;
            this.plusEquals.Text = "=";
            // 
            // plusResult
            // 
            this.plusResult.AutoSize = true;
            this.plusResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusResult.Location = new System.Drawing.Point(452, 55);
            this.plusResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.plusResult.Name = "plusResult";
            this.plusResult.Size = new System.Drawing.Size(24, 20);
            this.plusResult.TabIndex = 6;
            this.plusResult.Text = "...";
            // 
            // minusResult
            // 
            this.minusResult.AutoSize = true;
            this.minusResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusResult.Location = new System.Drawing.Point(452, 98);
            this.minusResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.minusResult.Name = "minusResult";
            this.minusResult.Size = new System.Drawing.Size(24, 20);
            this.minusResult.TabIndex = 9;
            this.minusResult.Text = "...";
            // 
            // minusEquals
            // 
            this.minusEquals.AutoSize = true;
            this.minusEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusEquals.Location = new System.Drawing.Point(410, 101);
            this.minusEquals.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.minusEquals.Name = "minusEquals";
            this.minusEquals.Size = new System.Drawing.Size(19, 20);
            this.minusEquals.TabIndex = 8;
            this.minusEquals.Text = "=";
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(363, 95);
            this.minusButton.Margin = new System.Windows.Forms.Padding(5);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(37, 34);
            this.minusButton.TabIndex = 7;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // divideResult
            // 
            this.divideResult.AutoSize = true;
            this.divideResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideResult.Location = new System.Drawing.Point(452, 185);
            this.divideResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.divideResult.Name = "divideResult";
            this.divideResult.Size = new System.Drawing.Size(24, 20);
            this.divideResult.TabIndex = 15;
            this.divideResult.Text = "...";
            // 
            // divideEquals
            // 
            this.divideEquals.AutoSize = true;
            this.divideEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideEquals.Location = new System.Drawing.Point(410, 188);
            this.divideEquals.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.divideEquals.Name = "divideEquals";
            this.divideEquals.Size = new System.Drawing.Size(19, 20);
            this.divideEquals.TabIndex = 14;
            this.divideEquals.Text = "=";
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(363, 182);
            this.divideButton.Margin = new System.Windows.Forms.Padding(5);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(37, 34);
            this.divideButton.TabIndex = 13;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // multiplyResult
            // 
            this.multiplyResult.AutoSize = true;
            this.multiplyResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyResult.Location = new System.Drawing.Point(452, 142);
            this.multiplyResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.multiplyResult.Name = "multiplyResult";
            this.multiplyResult.Size = new System.Drawing.Size(24, 20);
            this.multiplyResult.TabIndex = 12;
            this.multiplyResult.Text = "...";
            // 
            // multiplyEquals
            // 
            this.multiplyEquals.AutoSize = true;
            this.multiplyEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyEquals.Location = new System.Drawing.Point(410, 144);
            this.multiplyEquals.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.multiplyEquals.Name = "multiplyEquals";
            this.multiplyEquals.Size = new System.Drawing.Size(19, 20);
            this.multiplyEquals.TabIndex = 11;
            this.multiplyEquals.Text = "=";
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(363, 138);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(5);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(37, 34);
            this.multiplyButton.TabIndex = 10;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // powerResult
            // 
            this.powerResult.AutoSize = true;
            this.powerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerResult.Location = new System.Drawing.Point(452, 229);
            this.powerResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.powerResult.Name = "powerResult";
            this.powerResult.Size = new System.Drawing.Size(24, 20);
            this.powerResult.TabIndex = 18;
            this.powerResult.Text = "...";
            // 
            // powerEquals
            // 
            this.powerEquals.AutoSize = true;
            this.powerEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerEquals.Location = new System.Drawing.Point(410, 232);
            this.powerEquals.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.powerEquals.Name = "powerEquals";
            this.powerEquals.Size = new System.Drawing.Size(19, 20);
            this.powerEquals.TabIndex = 17;
            this.powerEquals.Text = "=";
            // 
            // powerButton
            // 
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerButton.Location = new System.Drawing.Point(363, 226);
            this.powerButton.Margin = new System.Windows.Forms.Padding(5);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(37, 34);
            this.powerButton.TabIndex = 16;
            this.powerButton.Text = "^";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // WillemKlein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 290);
            this.Controls.Add(this.powerResult);
            this.Controls.Add(this.powerEquals);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.divideResult);
            this.Controls.Add(this.divideEquals);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyResult);
            this.Controls.Add(this.multiplyEquals);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.minusResult);
            this.Controls.Add(this.minusEquals);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusResult);
            this.Controls.Add(this.plusEquals);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.labelA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WillemKlein";
            this.Text = "Willem Klein";
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.NumericUpDown inputA;
        private System.Windows.Forms.NumericUpDown inputB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Label plusEquals;
        private System.Windows.Forms.Label plusResult;
        private System.Windows.Forms.Label minusResult;
        private System.Windows.Forms.Label minusEquals;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Label divideResult;
        private System.Windows.Forms.Label divideEquals;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Label multiplyResult;
        private System.Windows.Forms.Label multiplyEquals;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Label powerResult;
        private System.Windows.Forms.Label powerEquals;
        private System.Windows.Forms.Button powerButton;
    }
}

