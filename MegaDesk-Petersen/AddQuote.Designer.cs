namespace MegaDesk_Petersen
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.customerFullName = new System.Windows.Forms.TextBox();
            this.lblDeskWidth = new System.Windows.Forms.Label();
            this.deskWidth = new System.Windows.Forms.TextBox();
            this.lblDeskDepth = new System.Windows.Forms.Label();
            this.deskDepth = new System.Windows.Forms.TextBox();
            this.lblNumDrawers = new System.Windows.Forms.Label();
            this.numDrawers = new System.Windows.Forms.ComboBox();
            this.lblSurfaceMaterial = new System.Windows.Forms.Label();
            this.cmbSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.lblRushOrderDays = new System.Windows.Forms.Label();
            this.rushOrder = new System.Windows.Forms.ComboBox();
            this.btnSubmitQuote = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerFullName
            // 
            this.lblCustomerFullName.AutoSize = true;
            this.lblCustomerFullName.Location = new System.Drawing.Point(26, 39);
            this.lblCustomerFullName.Name = "lblCustomerFullName";
            this.lblCustomerFullName.Size = new System.Drawing.Size(101, 13);
            this.lblCustomerFullName.TabIndex = 0;
            this.lblCustomerFullName.Text = "Customer Full Name";
            // 
            // customerFullName
            // 
            this.customerFullName.Location = new System.Drawing.Point(139, 36);
            this.customerFullName.Name = "customerFullName";
            this.customerFullName.Size = new System.Drawing.Size(100, 20);
            this.customerFullName.TabIndex = 1;
            // 
            // lblDeskWidth
            // 
            this.lblDeskWidth.AutoSize = true;
            this.lblDeskWidth.Location = new System.Drawing.Point(64, 77);
            this.lblDeskWidth.Name = "lblDeskWidth";
            this.lblDeskWidth.Size = new System.Drawing.Size(63, 13);
            this.lblDeskWidth.TabIndex = 2;
            this.lblDeskWidth.Text = "Desk Width";
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(139, 74);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(100, 20);
            this.deskWidth.TabIndex = 3;
            // 
            // lblDeskDepth
            // 
            this.lblDeskDepth.AutoSize = true;
            this.lblDeskDepth.Location = new System.Drawing.Point(63, 115);
            this.lblDeskDepth.Name = "lblDeskDepth";
            this.lblDeskDepth.Size = new System.Drawing.Size(64, 13);
            this.lblDeskDepth.TabIndex = 4;
            this.lblDeskDepth.Text = "Desk Depth";
            // 
            // deskDepth
            // 
            this.deskDepth.Location = new System.Drawing.Point(139, 112);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(100, 20);
            this.deskDepth.TabIndex = 5;
            // 
            // lblNumDrawers
            // 
            this.lblNumDrawers.AutoSize = true;
            this.lblNumDrawers.Location = new System.Drawing.Point(41, 153);
            this.lblNumDrawers.Name = "lblNumDrawers";
            this.lblNumDrawers.Size = new System.Drawing.Size(86, 13);
            this.lblNumDrawers.TabIndex = 6;
            this.lblNumDrawers.Text = "Number Drawers";
            // 
            // numDrawers
            // 
            this.numDrawers.FormattingEnabled = true;
            this.numDrawers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.numDrawers.Location = new System.Drawing.Point(139, 150);
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(100, 21);
            this.numDrawers.TabIndex = 7;
            // 
            // lblSurfaceMaterial
            // 
            this.lblSurfaceMaterial.AutoSize = true;
            this.lblSurfaceMaterial.Location = new System.Drawing.Point(43, 191);
            this.lblSurfaceMaterial.Name = "lblSurfaceMaterial";
            this.lblSurfaceMaterial.Size = new System.Drawing.Size(84, 13);
            this.lblSurfaceMaterial.TabIndex = 8;
            this.lblSurfaceMaterial.Text = "Surface Material";
            // 
            // cmbSurfaceMaterial
            // 
            this.cmbSurfaceMaterial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deskBindingSource, "surfaceMaterial", true));
            this.cmbSurfaceMaterial.FormattingEnabled = true;
            this.cmbSurfaceMaterial.Location = new System.Drawing.Point(139, 189);
            this.cmbSurfaceMaterial.Name = "cmbSurfaceMaterial";
            this.cmbSurfaceMaterial.Size = new System.Drawing.Size(100, 21);
            this.cmbSurfaceMaterial.TabIndex = 9;
            // 
            // lblRushOrderDays
            // 
            this.lblRushOrderDays.AutoSize = true;
            this.lblRushOrderDays.Location = new System.Drawing.Point(39, 228);
            this.lblRushOrderDays.Name = "lblRushOrderDays";
            this.lblRushOrderDays.Size = new System.Drawing.Size(88, 13);
            this.lblRushOrderDays.TabIndex = 10;
            this.lblRushOrderDays.Text = "Rush Order Days";
            // 
            // rushOrder
            // 
            this.rushOrder.FormattingEnabled = true;
            this.rushOrder.Location = new System.Drawing.Point(139, 228);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(100, 21);
            this.rushOrder.TabIndex = 11;
            // 
            // btnSubmitQuote
            // 
            this.btnSubmitQuote.Location = new System.Drawing.Point(139, 269);
            this.btnSubmitQuote.Name = "btnSubmitQuote";
            this.btnSubmitQuote.Size = new System.Drawing.Size(100, 23);
            this.btnSubmitQuote.TabIndex = 12;
            this.btnSubmitQuote.Text = "Submit Quote";
            this.btnSubmitQuote.UseVisualStyleBackColor = true;
            this.btnSubmitQuote.Click += new System.EventHandler(this.btnSubmitQuote_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(713, 415);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMainMenu.TabIndex = 13;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // deskBindingSource
            // 
            this.deskBindingSource.DataSource = typeof(MegaDesk_Petersen.Desk);
            // 
            // deskBindingSource1
            // 
            this.deskBindingSource1.DataSource = typeof(MegaDesk_Petersen.Desk);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnSubmitQuote);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.lblRushOrderDays);
            this.Controls.Add(this.cmbSurfaceMaterial);
            this.Controls.Add(this.lblSurfaceMaterial);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.lblNumDrawers);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.lblDeskDepth);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.lblDeskWidth);
            this.Controls.Add(this.customerFullName);
            this.Controls.Add(this.lblCustomerFullName);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.TextBox customerFullName;
        private System.Windows.Forms.Label lblDeskWidth;
        private System.Windows.Forms.TextBox deskWidth;
        private System.Windows.Forms.Label lblDeskDepth;
        private System.Windows.Forms.TextBox deskDepth;
        private System.Windows.Forms.Label lblNumDrawers;
        private System.Windows.Forms.ComboBox numDrawers;
        private System.Windows.Forms.Label lblSurfaceMaterial;
        private System.Windows.Forms.ComboBox cmbSurfaceMaterial;
        private System.Windows.Forms.Label lblRushOrderDays;
        private System.Windows.Forms.ComboBox rushOrder;
        private System.Windows.Forms.Button btnSubmitQuote;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.BindingSource deskBindingSource;
        private System.Windows.Forms.BindingSource deskBindingSource1;
    }
}