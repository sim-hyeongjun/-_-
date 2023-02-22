namespace ggiptoject1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.add = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.cob = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.divied = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.White;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(365, 56);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.add, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.point, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ac, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.minus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cob, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.divied, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 405);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.add.Location = new System.Drawing.Point(273, 306);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(84, 95);
            this.add.TabIndex = 15;
            this.add.TabStop = false;
            this.add.Text = "＋";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // point
            // 
            this.point.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point.Location = new System.Drawing.Point(183, 306);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(84, 95);
            this.point.TabIndex = 14;
            this.point.TabStop = false;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.add_Click);
            // 
            // ac
            // 
            this.ac.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ac.Location = new System.Drawing.Point(3, 306);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(84, 95);
            this.ac.TabIndex = 12;
            this.ac.TabStop = false;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.add_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minus.Location = new System.Drawing.Point(273, 205);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(84, 95);
            this.minus.TabIndex = 11;
            this.minus.TabStop = false;
            this.minus.Text = "－";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.add_Click);
            // 
            // cob
            // 
            this.cob.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cob.Location = new System.Drawing.Point(273, 104);
            this.cob.Name = "cob";
            this.cob.Size = new System.Drawing.Size(84, 95);
            this.cob.TabIndex = 7;
            this.cob.TabStop = false;
            this.cob.Text = "×";
            this.cob.UseVisualStyleBackColor = true;
            this.cob.Click += new System.EventHandler(this.add_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button0.Location = new System.Drawing.Point(93, 306);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(84, 95);
            this.button0.TabIndex = 13;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 95);
            this.button7.TabIndex = 0;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button0_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(93, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 95);
            this.button8.TabIndex = 1;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(183, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 95);
            this.button9.TabIndex = 2;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button0_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(183, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 95);
            this.button6.TabIndex = 6;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button0_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(93, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 95);
            this.button5.TabIndex = 5;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button0_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(3, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 95);
            this.button4.TabIndex = 4;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button0_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(183, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 95);
            this.button3.TabIndex = 10;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button0_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(93, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 95);
            this.button2.TabIndex = 9;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(3, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 95);
            this.button1.TabIndex = 8;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button0_Click);
            // 
            // divied
            // 
            this.divied.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.divied.Location = new System.Drawing.Point(273, 3);
            this.divied.Name = "divied";
            this.divied.Size = new System.Drawing.Size(84, 95);
            this.divied.TabIndex = 3;
            this.divied.TabStop = false;
            this.divied.Text = "÷";
            this.divied.UseVisualStyleBackColor = true;
            this.divied.Click += new System.EventHandler(this.add_Click);
            // 
            // result
            // 
            this.result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.result.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result.Location = new System.Drawing.Point(0, 466);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(365, 70);
            this.result.TabIndex = 2;
            this.result.TabStop = false;
            this.result.Text = "＝";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 536);
            this.Controls.Add(this.result);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button cob;
        private System.Windows.Forms.Button divied;
        private System.Windows.Forms.Button result;

        // 숫자 버튼
        private System.Windows.Forms.Button button0;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;

    }
}

