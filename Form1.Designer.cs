namespace ExcelDataReader
{
    partial class Form1
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
            this.foodBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.convertSourcesBtn = new System.Windows.Forms.Button();
            this.convertFoodParamsBtn = new System.Windows.Forms.Button();
            this.FoodparamsToParamGroupsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.foodToFoodGroupBtn = new System.Windows.Forms.Button();
            this.generateFoodSourceBtn = new System.Windows.Forms.Button();
            this.convertParametersToParameterUnitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodBtn
            // 
            this.foodBtn.Location = new System.Drawing.Point(6, 33);
            this.foodBtn.Name = "foodBtn";
            this.foodBtn.Size = new System.Drawing.Size(114, 52);
            this.foodBtn.TabIndex = 2;
            this.foodBtn.Text = "Convert food to FoodAsJSON";
            this.foodBtn.UseVisualStyleBackColor = true;
            this.foodBtn.Click += new System.EventHandler(this.foodBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Convert parameter to JSON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.parametersBtn_Click);
            // 
            // convertSourcesBtn
            // 
            this.convertSourcesBtn.Location = new System.Drawing.Point(6, 19);
            this.convertSourcesBtn.Name = "convertSourcesBtn";
            this.convertSourcesBtn.Size = new System.Drawing.Size(114, 52);
            this.convertSourcesBtn.TabIndex = 5;
            this.convertSourcesBtn.Text = "Convert sources to JSON";
            this.convertSourcesBtn.UseVisualStyleBackColor = true;
            this.convertSourcesBtn.Click += new System.EventHandler(this.convertSourcesBtn_Click);
            // 
            // convertFoodParamsBtn
            // 
            this.convertFoodParamsBtn.Location = new System.Drawing.Point(6, 42);
            this.convertFoodParamsBtn.Name = "convertFoodParamsBtn";
            this.convertFoodParamsBtn.Size = new System.Drawing.Size(105, 52);
            this.convertFoodParamsBtn.TabIndex = 6;
            this.convertFoodParamsBtn.Text = "Convert foodparameters as JSON";
            this.convertFoodParamsBtn.UseVisualStyleBackColor = true;
            this.convertFoodParamsBtn.Click += new System.EventHandler(this.ConvertFoodParamsBtnClick);
            // 
            // FoodparamsToParamGroupsBtn
            // 
            this.FoodparamsToParamGroupsBtn.Location = new System.Drawing.Point(261, 36);
            this.FoodparamsToParamGroupsBtn.Name = "FoodparamsToParamGroupsBtn";
            this.FoodparamsToParamGroupsBtn.Size = new System.Drawing.Size(134, 52);
            this.FoodparamsToParamGroupsBtn.TabIndex = 7;
            this.FoodparamsToParamGroupsBtn.Text = "Convert FoodParameters to ParameterGroups as JSON";
            this.FoodparamsToParamGroupsBtn.UseVisualStyleBackColor = true;
            this.FoodparamsToParamGroupsBtn.Click += new System.EventHandler(this.ParametersToParamGroupsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Food";
            // 
            // foodToFoodGroupBtn
            // 
            this.foodToFoodGroupBtn.Location = new System.Drawing.Point(126, 33);
            this.foodToFoodGroupBtn.Name = "foodToFoodGroupBtn";
            this.foodToFoodGroupBtn.Size = new System.Drawing.Size(111, 52);
            this.foodToFoodGroupBtn.TabIndex = 10;
            this.foodToFoodGroupBtn.Text = "Convert food to FoodGroupAsJSON";
            this.foodToFoodGroupBtn.UseVisualStyleBackColor = true;
            this.foodToFoodGroupBtn.Click += new System.EventHandler(this.foodToFoodGroupBtn_Click);
            // 
            // generateFoodSourceBtn
            // 
            this.generateFoodSourceBtn.Location = new System.Drawing.Point(256, 33);
            this.generateFoodSourceBtn.Name = "generateFoodSourceBtn";
            this.generateFoodSourceBtn.Size = new System.Drawing.Size(119, 53);
            this.generateFoodSourceBtn.TabIndex = 11;
            this.generateFoodSourceBtn.Text = "Generate FoodSourceAsJSON";
            this.generateFoodSourceBtn.UseVisualStyleBackColor = true;
            this.generateFoodSourceBtn.Click += new System.EventHandler(this.generateFoodSourceBtn_Click);
            // 
            // convertParametersToParameterUnitBtn
            // 
            this.convertParametersToParameterUnitBtn.Location = new System.Drawing.Point(134, 36);
            this.convertParametersToParameterUnitBtn.Name = "convertParametersToParameterUnitBtn";
            this.convertParametersToParameterUnitBtn.Size = new System.Drawing.Size(111, 52);
            this.convertParametersToParameterUnitBtn.TabIndex = 12;
            this.convertParametersToParameterUnitBtn.Text = "Convert parameters to ParameterUnit";
            this.convertParametersToParameterUnitBtn.UseVisualStyleBackColor = true;
            this.convertParametersToParameterUnitBtn.Click += new System.EventHandler(this.convertParametersToParameterUnitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "FoodGroup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "FoodSource";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.foodBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.generateFoodSourceBtn);
            this.groupBox1.Controls.Add(this.foodToFoodGroupBtn);
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.FoodparamsToParamGroupsBtn);
            this.groupBox2.Controls.Add(this.convertParametersToParameterUnitBtn);
            this.groupBox2.Location = new System.Drawing.Point(21, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ParameterUnit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parameter";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.convertFoodParamsBtn);
            this.groupBox3.Location = new System.Drawing.Point(21, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FoodParameter (Data_Normalized)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "FoodParameters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ParameterGroups";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.convertSourcesBtn);
            this.groupBox4.Location = new System.Drawing.Point(21, 352);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 87);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sources";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button foodBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button convertSourcesBtn;
        private System.Windows.Forms.Button convertFoodParamsBtn;
        private System.Windows.Forms.Button FoodparamsToParamGroupsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button foodToFoodGroupBtn;
        private System.Windows.Forms.Button generateFoodSourceBtn;
        private System.Windows.Forms.Button convertParametersToParameterUnitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

