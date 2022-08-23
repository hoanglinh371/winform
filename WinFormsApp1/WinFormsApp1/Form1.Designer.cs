namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.aLbl = new System.Windows.Forms.Label();
            this.bLbl = new System.Windows.Forms.Label();
            this.aInput = new System.Windows.Forms.TextBox();
            this.bInput = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.resultBtn = new System.Windows.Forms.Button();
            this.againBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.emptyError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.emptyError)).BeginInit();
            this.SuspendLayout();
            // 
            // aLbl
            // 
            this.aLbl.AutoSize = true;
            this.aLbl.Location = new System.Drawing.Point(41, 61);
            this.aLbl.Name = "aLbl";
            this.aLbl.Size = new System.Drawing.Size(43, 15);
            this.aLbl.TabIndex = 0;
            this.aLbl.Text = "Enter a";
            // 
            // bLbl
            // 
            this.bLbl.AutoSize = true;
            this.bLbl.Location = new System.Drawing.Point(41, 151);
            this.bLbl.Name = "bLbl";
            this.bLbl.Size = new System.Drawing.Size(44, 15);
            this.bLbl.TabIndex = 1;
            this.bLbl.Text = "Enter b";
            // 
            // aInput
            // 
            this.aInput.Location = new System.Drawing.Point(152, 61);
            this.aInput.Name = "aInput";
            this.aInput.Size = new System.Drawing.Size(100, 23);
            this.aInput.TabIndex = 2;
            this.aInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aInput_KeyPress);
            this.aInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.aInput_MouseMove);
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(152, 151);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(100, 23);
            this.bInput.TabIndex = 3;
            this.bInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bInput_KeyPress);
            this.bInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bInput_MouseMove);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLbl.ForeColor = System.Drawing.Color.Red;
            this.resultLbl.Location = new System.Drawing.Point(41, 267);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(213, 20);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "Total from a to b is: ";
            // 
            // resultBtn
            // 
            this.resultBtn.Location = new System.Drawing.Point(152, 354);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(75, 23);
            this.resultBtn.TabIndex = 5;
            this.resultBtn.Text = "Result";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // againBtn
            // 
            this.againBtn.Location = new System.Drawing.Point(329, 354);
            this.againBtn.Name = "againBtn";
            this.againBtn.Size = new System.Drawing.Size(75, 23);
            this.againBtn.TabIndex = 6;
            this.againBtn.Text = "Again";
            this.againBtn.UseVisualStyleBackColor = true;
            this.againBtn.Click += new System.EventHandler(this.againBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(531, 354);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // emptyError
            // 
            this.emptyError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.againBtn);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.aInput);
            this.Controls.Add(this.bLbl);
            this.Controls.Add(this.aLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.emptyError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label aLbl;
        private Label bLbl;
        private TextBox aInput;
        private TextBox bInput;
        private Label resultLbl;
        private Button resultBtn;
        private Button againBtn;
        private Button exitBtn;
        private ToolTip toolTip1;
        private ErrorProvider emptyError;
    }
}