namespace Задание_1_г
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
            this.ShowCord = new System.Windows.Forms.TextBox();
            this.YmnScalar = new System.Windows.Forms.Button();
            this.VectorgroupBox = new System.Windows.Forms.GroupBox();
            this.Alabel = new System.Windows.Forms.Label();
            this.Blabel = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.NumericUpDown();
            this.PerVectorbutton = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.NumericUpDown();
            this.CordPointgroupBox = new System.Windows.Forms.GroupBox();
            this.ZadXY = new System.Windows.Forms.Button();
            this.XYlabel = new System.Windows.Forms.Label();
            this.XY = new System.Windows.Forms.TextBox();
            this.ZadOrd = new System.Windows.Forms.Button();
            this.ZadAb = new System.Windows.Forms.Button();
            this.Xlabel = new System.Windows.Forms.Label();
            this.Ylabel = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.NumericUpDown();
            this.Y = new System.Windows.Forms.NumericUpDown();
            this.ZadCordbutton = new System.Windows.Forms.Button();
            this.Scalar = new System.Windows.Forms.NumericUpDown();
            this.Scalarlabel = new System.Windows.Forms.Label();
            this.RasNachDoToch = new System.Windows.Forms.Button();
            this.Ras = new System.Windows.Forms.TextBox();
            this.Raslabel = new System.Windows.Forms.Label();
            this.ShowCordlable = new System.Windows.Forms.Label();
            this.Inkr = new System.Windows.Forms.Button();
            this.Dekr = new System.Windows.Forms.Button();
            this.Odinlabel = new System.Windows.Forms.Label();
            this.Odin = new System.Windows.Forms.TextBox();
            this.YvelScalar = new System.Windows.Forms.Button();
            this.VectorgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            this.CordPointgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scalar)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowCord
            // 
            this.ShowCord.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCord.Location = new System.Drawing.Point(1007, 375);
            this.ShowCord.Name = "ShowCord";
            this.ShowCord.ReadOnly = true;
            this.ShowCord.Size = new System.Drawing.Size(193, 36);
            this.ShowCord.TabIndex = 30;
            // 
            // YmnScalar
            // 
            this.YmnScalar.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YmnScalar.Location = new System.Drawing.Point(566, 82);
            this.YmnScalar.Name = "YmnScalar";
            this.YmnScalar.Size = new System.Drawing.Size(435, 46);
            this.YmnScalar.TabIndex = 29;
            this.YmnScalar.Text = "Умножить координаты на скаляр ";
            this.YmnScalar.UseVisualStyleBackColor = true;
            this.YmnScalar.Click += new System.EventHandler(this.YmnScalar_Click);
            // 
            // VectorgroupBox
            // 
            this.VectorgroupBox.Controls.Add(this.Alabel);
            this.VectorgroupBox.Controls.Add(this.Blabel);
            this.VectorgroupBox.Controls.Add(this.A);
            this.VectorgroupBox.Controls.Add(this.PerVectorbutton);
            this.VectorgroupBox.Controls.Add(this.B);
            this.VectorgroupBox.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VectorgroupBox.Location = new System.Drawing.Point(1017, 12);
            this.VectorgroupBox.Name = "VectorgroupBox";
            this.VectorgroupBox.Size = new System.Drawing.Size(300, 200);
            this.VectorgroupBox.TabIndex = 28;
            this.VectorgroupBox.TabStop = false;
            this.VectorgroupBox.Text = "Вектор";
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alabel.Location = new System.Drawing.Point(28, 34);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(24, 28);
            this.Alabel.TabIndex = 10;
            this.Alabel.Text = "a";
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Blabel.Location = new System.Drawing.Point(28, 77);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(25, 28);
            this.Blabel.TabIndex = 11;
            this.Blabel.Text = "b";
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A.Location = new System.Drawing.Point(129, 32);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 36);
            this.A.TabIndex = 12;
            this.A.ValueChanged += new System.EventHandler(this.A_ValueChanged);
            // 
            // PerVectorbutton
            // 
            this.PerVectorbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PerVectorbutton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerVectorbutton.Location = new System.Drawing.Point(6, 122);
            this.PerVectorbutton.Name = "PerVectorbutton";
            this.PerVectorbutton.Size = new System.Drawing.Size(288, 70);
            this.PerVectorbutton.TabIndex = 15;
            this.PerVectorbutton.Text = "Переместить точку на вектор";
            this.PerVectorbutton.UseVisualStyleBackColor = true;
            this.PerVectorbutton.Click += new System.EventHandler(this.PerVectorbutton_Click);
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B.Location = new System.Drawing.Point(129, 75);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 36);
            this.B.TabIndex = 13;
            this.B.ValueChanged += new System.EventHandler(this.B_ValueChanged);
            // 
            // CordPointgroupBox
            // 
            this.CordPointgroupBox.Controls.Add(this.ZadXY);
            this.CordPointgroupBox.Controls.Add(this.XYlabel);
            this.CordPointgroupBox.Controls.Add(this.XY);
            this.CordPointgroupBox.Controls.Add(this.ZadOrd);
            this.CordPointgroupBox.Controls.Add(this.ZadAb);
            this.CordPointgroupBox.Controls.Add(this.Xlabel);
            this.CordPointgroupBox.Controls.Add(this.Ylabel);
            this.CordPointgroupBox.Controls.Add(this.X);
            this.CordPointgroupBox.Controls.Add(this.Y);
            this.CordPointgroupBox.Controls.Add(this.ZadCordbutton);
            this.CordPointgroupBox.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CordPointgroupBox.Location = new System.Drawing.Point(12, 12);
            this.CordPointgroupBox.Name = "CordPointgroupBox";
            this.CordPointgroupBox.Size = new System.Drawing.Size(534, 351);
            this.CordPointgroupBox.TabIndex = 27;
            this.CordPointgroupBox.TabStop = false;
            this.CordPointgroupBox.Text = "Координаты точки";
            // 
            // ZadXY
            // 
            this.ZadXY.Location = new System.Drawing.Point(49, 262);
            this.ZadXY.Name = "ZadXY";
            this.ZadXY.Size = new System.Drawing.Size(418, 55);
            this.ZadXY.TabIndex = 9;
            this.ZadXY.Text = "Задать координаты через строку";
            this.ZadXY.UseVisualStyleBackColor = true;
            this.ZadXY.Click += new System.EventHandler(this.ZadXY_Click);
            // 
            // XYlabel
            // 
            this.XYlabel.AutoSize = true;
            this.XYlabel.Location = new System.Drawing.Point(44, 205);
            this.XYlabel.Name = "XYlabel";
            this.XYlabel.Size = new System.Drawing.Size(192, 28);
            this.XYlabel.TabIndex = 9;
            this.XYlabel.Text = "Координаты x y";
            // 
            // XY
            // 
            this.XY.Location = new System.Drawing.Point(252, 202);
            this.XY.Name = "XY";
            this.XY.Size = new System.Drawing.Size(215, 36);
            this.XY.TabIndex = 8;
            this.XY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XY_KeyPress);
            // 
            // ZadOrd
            // 
            this.ZadOrd.Location = new System.Drawing.Point(295, 72);
            this.ZadOrd.Name = "ZadOrd";
            this.ZadOrd.Size = new System.Drawing.Size(227, 38);
            this.ZadOrd.TabIndex = 7;
            this.ZadOrd.Text = "Задать ординату";
            this.ZadOrd.UseVisualStyleBackColor = true;
            this.ZadOrd.Click += new System.EventHandler(this.ZadOrd_Click);
            // 
            // ZadAb
            // 
            this.ZadAb.Location = new System.Drawing.Point(295, 24);
            this.ZadAb.Name = "ZadAb";
            this.ZadAb.Size = new System.Drawing.Size(227, 37);
            this.ZadAb.TabIndex = 6;
            this.ZadAb.Text = "Задать Абсциса";
            this.ZadAb.UseVisualStyleBackColor = true;
            this.ZadAb.Click += new System.EventHandler(this.ZadAb_Click);
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Xlabel.Location = new System.Drawing.Point(5, 34);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(133, 28);
            this.Xlabel.TabIndex = 0;
            this.Xlabel.Text = "Абсциса, x";
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ylabel.Location = new System.Drawing.Point(5, 77);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(150, 28);
            this.Ylabel.TabIndex = 2;
            this.Ylabel.Text = "Ордината, y";
            // 
            // X
            // 
            this.X.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(177, 26);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(100, 36);
            this.X.TabIndex = 1;
            this.X.ValueChanged += new System.EventHandler(this.X_ValueChanged);
            // 
            // Y
            // 
            this.Y.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(177, 75);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(100, 36);
            this.Y.TabIndex = 3;
            this.Y.ValueChanged += new System.EventHandler(this.Y_ValueChanged);
            // 
            // ZadCordbutton
            // 
            this.ZadCordbutton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZadCordbutton.Location = new System.Drawing.Point(142, 127);
            this.ZadCordbutton.Name = "ZadCordbutton";
            this.ZadCordbutton.Size = new System.Drawing.Size(267, 60);
            this.ZadCordbutton.TabIndex = 6;
            this.ZadCordbutton.Text = "Задать координаты";
            this.ZadCordbutton.UseVisualStyleBackColor = true;
            this.ZadCordbutton.Click += new System.EventHandler(this.ZadCordbutton_Click);
            // 
            // Scalar
            // 
            this.Scalar.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Scalar.Location = new System.Drawing.Point(747, 36);
            this.Scalar.Name = "Scalar";
            this.Scalar.Size = new System.Drawing.Size(170, 36);
            this.Scalar.TabIndex = 26;
            this.Scalar.ValueChanged += new System.EventHandler(this.Scalar_ValueChanged);
            // 
            // Scalarlabel
            // 
            this.Scalarlabel.AutoSize = true;
            this.Scalarlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Scalarlabel.Location = new System.Drawing.Point(624, 36);
            this.Scalarlabel.Name = "Scalarlabel";
            this.Scalarlabel.Size = new System.Drawing.Size(94, 28);
            this.Scalarlabel.TabIndex = 25;
            this.Scalarlabel.Text = "Скаляр";
            // 
            // RasNachDoToch
            // 
            this.RasNachDoToch.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RasNachDoToch.Location = new System.Drawing.Point(792, 243);
            this.RasNachDoToch.Name = "RasNachDoToch";
            this.RasNachDoToch.Size = new System.Drawing.Size(308, 55);
            this.RasNachDoToch.TabIndex = 24;
            this.RasNachDoToch.Text = "Рассчитать расстояние";
            this.RasNachDoToch.UseVisualStyleBackColor = true;
            this.RasNachDoToch.Click += new System.EventHandler(this.RasNachDoToch_Click);
            // 
            // Ras
            // 
            this.Ras.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ras.Location = new System.Drawing.Point(1090, 304);
            this.Ras.Name = "Ras";
            this.Ras.ReadOnly = true;
            this.Ras.Size = new System.Drawing.Size(167, 36);
            this.Ras.TabIndex = 23;
            // 
            // Raslabel
            // 
            this.Raslabel.AutoSize = true;
            this.Raslabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Raslabel.Location = new System.Drawing.Point(581, 307);
            this.Raslabel.Name = "Raslabel";
            this.Raslabel.Size = new System.Drawing.Size(489, 28);
            this.Raslabel.TabIndex = 22;
            this.Raslabel.Text = "Расстояние от начала координат до точки";
            // 
            // ShowCordlable
            // 
            this.ShowCordlable.AutoSize = true;
            this.ShowCordlable.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCordlable.Location = new System.Drawing.Point(630, 378);
            this.ShowCordlable.Name = "ShowCordlable";
            this.ShowCordlable.Size = new System.Drawing.Size(362, 28);
            this.ShowCordlable.TabIndex = 21;
            this.ShowCordlable.Text = "Координаты точки через Show";
            // 
            // Inkr
            // 
            this.Inkr.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inkr.Location = new System.Drawing.Point(792, 182);
            this.Inkr.Name = "Inkr";
            this.Inkr.Size = new System.Drawing.Size(180, 42);
            this.Inkr.TabIndex = 31;
            this.Inkr.Text = "Инкремент";
            this.Inkr.UseVisualStyleBackColor = true;
            this.Inkr.Click += new System.EventHandler(this.Inkr_Click);
            // 
            // Dekr
            // 
            this.Dekr.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dekr.Location = new System.Drawing.Point(595, 182);
            this.Dekr.Name = "Dekr";
            this.Dekr.Size = new System.Drawing.Size(180, 42);
            this.Dekr.TabIndex = 32;
            this.Dekr.Text = "Декремент";
            this.Dekr.UseVisualStyleBackColor = true;
            this.Dekr.Click += new System.EventHandler(this.Dekr_Click);
            // 
            // Odinlabel
            // 
            this.Odinlabel.AutoSize = true;
            this.Odinlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Odinlabel.Location = new System.Drawing.Point(30, 378);
            this.Odinlabel.Name = "Odinlabel";
            this.Odinlabel.Size = new System.Drawing.Size(372, 28);
            this.Odinlabel.TabIndex = 33;
            this.Odinlabel.Text = "Значение полей x и у совпадает";
            // 
            // Odin
            // 
            this.Odin.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Odin.Location = new System.Drawing.Point(434, 375);
            this.Odin.Name = "Odin";
            this.Odin.ReadOnly = true;
            this.Odin.Size = new System.Drawing.Size(100, 36);
            this.Odin.TabIndex = 34;
            // 
            // YvelScalar
            // 
            this.YvelScalar.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YvelScalar.Location = new System.Drawing.Point(566, 130);
            this.YvelScalar.Name = "YvelScalar";
            this.YvelScalar.Size = new System.Drawing.Size(435, 46);
            this.YvelScalar.TabIndex = 35;
            this.YvelScalar.Text = "Увеличить координаты на скаляр";
            this.YvelScalar.UseVisualStyleBackColor = true;
            this.YvelScalar.Click += new System.EventHandler(this.YvelScalar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 433);
            this.Controls.Add(this.YvelScalar);
            this.Controls.Add(this.Odin);
            this.Controls.Add(this.Odinlabel);
            this.Controls.Add(this.Dekr);
            this.Controls.Add(this.Inkr);
            this.Controls.Add(this.ShowCord);
            this.Controls.Add(this.YmnScalar);
            this.Controls.Add(this.VectorgroupBox);
            this.Controls.Add(this.CordPointgroupBox);
            this.Controls.Add(this.Scalar);
            this.Controls.Add(this.Scalarlabel);
            this.Controls.Add(this.RasNachDoToch);
            this.Controls.Add(this.Ras);
            this.Controls.Add(this.Raslabel);
            this.Controls.Add(this.ShowCordlable);
            this.Name = "Form1";
            this.Text = "Задание 1";
            this.VectorgroupBox.ResumeLayout(false);
            this.VectorgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            this.CordPointgroupBox.ResumeLayout(false);
            this.CordPointgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShowCord;
        private System.Windows.Forms.Button YmnScalar;
        private System.Windows.Forms.GroupBox VectorgroupBox;
        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.Label Blabel;
        private System.Windows.Forms.NumericUpDown A;
        private System.Windows.Forms.Button PerVectorbutton;
        private System.Windows.Forms.NumericUpDown B;
        private System.Windows.Forms.GroupBox CordPointgroupBox;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.NumericUpDown X;
        private System.Windows.Forms.NumericUpDown Y;
        private System.Windows.Forms.Button ZadCordbutton;
        private System.Windows.Forms.NumericUpDown Scalar;
        private System.Windows.Forms.Label Scalarlabel;
        private System.Windows.Forms.Button RasNachDoToch;
        private System.Windows.Forms.TextBox Ras;
        private System.Windows.Forms.Label Raslabel;
        private System.Windows.Forms.Label ShowCordlable;
        private System.Windows.Forms.Button Inkr;
        private System.Windows.Forms.Button Dekr;
        private System.Windows.Forms.Label Odinlabel;
        private System.Windows.Forms.TextBox Odin;
        private System.Windows.Forms.Button YvelScalar;
        private System.Windows.Forms.Button ZadOrd;
        private System.Windows.Forms.Button ZadAb;
        private System.Windows.Forms.Button ZadXY;
        private System.Windows.Forms.TextBox XY;
        private System.Windows.Forms.Label XYlabel;
    }
}

