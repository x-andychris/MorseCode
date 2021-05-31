namespace MorseCode
{
    partial class Home
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
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.btnToMorseCode = new System.Windows.Forms.Button();
            this.btnFromMorseCode = new System.Windows.Forms.Button();
            this.boxDisplayMethod = new System.Windows.Forms.ComboBox();
            this.txtBox2 = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(42, 46);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(274, 96);
            this.txtBox.TabIndex = 0;
            this.txtBox.Text = "";
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btnToMorseCode
            // 
            this.btnToMorseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToMorseCode.Location = new System.Drawing.Point(27, 165);
            this.btnToMorseCode.Name = "btnToMorseCode";
            this.btnToMorseCode.Size = new System.Drawing.Size(132, 29);
            this.btnToMorseCode.TabIndex = 1;
            this.btnToMorseCode.Text = "To Morse Code";
            this.btnToMorseCode.UseVisualStyleBackColor = true;
            this.btnToMorseCode.Click += new System.EventHandler(this.btnToMorseCode_Click);
            // 
            // btnFromMorseCode
            // 
            this.btnFromMorseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFromMorseCode.Location = new System.Drawing.Point(189, 165);
            this.btnFromMorseCode.Name = "btnFromMorseCode";
            this.btnFromMorseCode.Size = new System.Drawing.Size(145, 29);
            this.btnFromMorseCode.TabIndex = 2;
            this.btnFromMorseCode.Text = "From Morse Code";
            this.btnFromMorseCode.UseVisualStyleBackColor = true;
            this.btnFromMorseCode.Click += new System.EventHandler(this.btnFromMorseCode_Click);
            // 
            // boxDisplayMethod
            // 
            this.boxDisplayMethod.FormattingEnabled = true;
            this.boxDisplayMethod.Items.AddRange(new object[] {
            "Text",
            "Light",
            "Sound"});
            this.boxDisplayMethod.Location = new System.Drawing.Point(248, 12);
            this.boxDisplayMethod.Name = "boxDisplayMethod";
            this.boxDisplayMethod.Size = new System.Drawing.Size(121, 24);
            this.boxDisplayMethod.TabIndex = 3;
            this.boxDisplayMethod.SelectedIndexChanged += new System.EventHandler(this.boxDisplayMethod_SelectedIndexChanged);
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.Location = new System.Drawing.Point(42, 224);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(274, 129);
            this.txtBox2.TabIndex = 4;
            this.txtBox2.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(258, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(322, 224);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(42, 129);
            this.colorPanel.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 411);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.boxDisplayMethod);
            this.Controls.Add(this.btnFromMorseCode);
            this.Controls.Add(this.btnToMorseCode);
            this.Controls.Add(this.txtBox);
            this.Name = "Home";
            this.Text = "Easy Morse Code";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.Button btnToMorseCode;
        private System.Windows.Forms.Button btnFromMorseCode;
        private System.Windows.Forms.ComboBox boxDisplayMethod;
        private System.Windows.Forms.RichTextBox txtBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel colorPanel;
    }
}

