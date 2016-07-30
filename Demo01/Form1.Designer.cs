namespace Demo01
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

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingNavigator1 = new Gizmox.WebGUI.Forms.BindingNavigator(this.components);
            this.comboBox1 = new Gizmox.WebGUI.Forms.ComboBox();
            this.checkBox1 = new Gizmox.WebGUI.Forms.CheckBox();
            this.button1 = new Gizmox.WebGUI.Forms.Button();
            this.button2 = new Gizmox.WebGUI.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.DragHandle = true;
            this.bindingNavigator1.DropDownArrows = true;
            this.bindingNavigator1.ImageSize = new System.Drawing.Size(16, 16);
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MenuHandle = true;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.ShowToolTips = true;
            this.bindingNavigator1.Size = new System.Drawing.Size(360, 28);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.AddStandardItems();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(120, 214);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            // 
            // Form1
            // 
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Size = new System.Drawing.Size(360, 366);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.BindingNavigator bindingNavigator1;
        private Gizmox.WebGUI.Forms.ComboBox comboBox1;
        private Gizmox.WebGUI.Forms.CheckBox checkBox1;
        private Gizmox.WebGUI.Forms.Button button1;
        private Gizmox.WebGUI.Forms.Button button2;
    }
}