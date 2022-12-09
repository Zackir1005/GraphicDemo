namespace GraphicDemo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChangeFont = new System.Windows.Forms.Button();
            this.buttonClearRTB = new System.Windows.Forms.Button();
            this.buttonShowBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangeFont
            // 
            this.buttonChangeFont.Location = new System.Drawing.Point(4, 299);
            this.buttonChangeFont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChangeFont.Name = "buttonChangeFont";
            this.buttonChangeFont.Size = new System.Drawing.Size(100, 28);
            this.buttonChangeFont.TabIndex = 0;
            this.buttonChangeFont.Text = "Шрифт";
            this.buttonChangeFont.UseVisualStyleBackColor = true;
            this.buttonChangeFont.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonChangeFont_MouseClick);
            // 
            // buttonClearRTB
            // 
            this.buttonClearRTB.Location = new System.Drawing.Point(127, 299);
            this.buttonClearRTB.Name = "buttonClearRTB";
            this.buttonClearRTB.Size = new System.Drawing.Size(201, 26);
            this.buttonClearRTB.TabIndex = 1;
            this.buttonClearRTB.Text = "Убрать список шрифтов\r\n";
            this.buttonClearRTB.UseVisualStyleBackColor = true;
            this.buttonClearRTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClearRTB_MouseClick);
            // 
            // buttonShowBoard
            // 
            this.buttonShowBoard.Location = new System.Drawing.Point(359, 301);
            this.buttonShowBoard.Name = "buttonShowBoard";
            this.buttonShowBoard.Size = new System.Drawing.Size(75, 23);
            this.buttonShowBoard.TabIndex = 2;
            this.buttonShowBoard.Text = "Доска";
            this.buttonShowBoard.UseVisualStyleBackColor = true;
            this.buttonShowBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonShowBoard_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 325);
            this.Controls.Add(this.buttonShowBoard);
            this.Controls.Add(this.buttonClearRTB);
            this.Controls.Add(this.buttonChangeFont);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeFont;
        private System.Windows.Forms.Button buttonClearRTB;
        private System.Windows.Forms.Button buttonShowBoard;
    }
}

