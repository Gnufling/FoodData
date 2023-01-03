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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.foodBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FoodToJSONbtn = new System.Windows.Forms.Button();
            this.convertSourcesBtn = new System.Windows.Forms.Button();
            this.convertFoodParamsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // foodBtn
            // 
            this.foodBtn.Location = new System.Drawing.Point(21, 54);
            this.foodBtn.Name = "foodBtn";
            this.foodBtn.Size = new System.Drawing.Size(114, 52);
            this.foodBtn.TabIndex = 2;
            this.foodBtn.Text = "Convert food to JSON";
            this.foodBtn.UseVisualStyleBackColor = true;
            this.foodBtn.Click += new System.EventHandler(this.foodBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Convert parameters to JSON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.parametersBtn_Click);
            // 
            // FoodToJSONbtn
            // 
            this.FoodToJSONbtn.Location = new System.Drawing.Point(713, 54);
            this.FoodToJSONbtn.Name = "FoodToJSONbtn";
            this.FoodToJSONbtn.Size = new System.Drawing.Size(75, 23);
            this.FoodToJSONbtn.TabIndex = 4;
            this.FoodToJSONbtn.Text = "Food";
            this.FoodToJSONbtn.UseVisualStyleBackColor = true;
            this.FoodToJSONbtn.Click += new System.EventHandler(this.foodbtn_Click_1);
            // 
            // convertSourcesBtn
            // 
            this.convertSourcesBtn.Location = new System.Drawing.Point(222, 54);
            this.convertSourcesBtn.Name = "convertSourcesBtn";
            this.convertSourcesBtn.Size = new System.Drawing.Size(91, 52);
            this.convertSourcesBtn.TabIndex = 5;
            this.convertSourcesBtn.Text = "Convert sources to JSON";
            this.convertSourcesBtn.UseVisualStyleBackColor = true;
            this.convertSourcesBtn.Click += new System.EventHandler(this.convertSourcesBtn_Click);
            // 
            // convertFoodParamsBtn
            // 
            this.convertFoodParamsBtn.Location = new System.Drawing.Point(329, 54);
            this.convertFoodParamsBtn.Name = "convertFoodParamsBtn";
            this.convertFoodParamsBtn.Size = new System.Drawing.Size(105, 52);
            this.convertFoodParamsBtn.TabIndex = 6;
            this.convertFoodParamsBtn.Text = "Convert foodparameters as JSON";
            this.convertFoodParamsBtn.UseVisualStyleBackColor = true;
            this.convertFoodParamsBtn.Click += new System.EventHandler(this.ConvertFoodParamsBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convertFoodParamsBtn);
            this.Controls.Add(this.convertSourcesBtn);
            this.Controls.Add(this.FoodToJSONbtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.foodBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button foodBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button FoodToJSONbtn;
        private System.Windows.Forms.Button convertSourcesBtn;
        private System.Windows.Forms.Button convertFoodParamsBtn;
    }
}

