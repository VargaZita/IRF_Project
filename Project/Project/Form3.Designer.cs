namespace Project
{
    partial class Form3
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
            System.Windows.Forms.Label arLabel;
            System.Windows.Forms.Label nevLabel;
            System.Windows.Forms.Label uRLLabel;
            System.Windows.Forms.Label nevLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.arakBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.arakBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.arTextBox = new System.Windows.Forms.TextBox();
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.uRLTextBox = new System.Windows.Forms.TextBox();
            this.nevTextBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arakDataGridView = new System.Windows.Forms.DataGridView();
            this.TermekListBox = new System.Windows.Forms.ListBox();
            this.TermekTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KedvezmenyButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KedvezmenyszazalekTextBox = new System.Windows.Forms.TextBox();
            this.KedvezmenykodTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.boltokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.termekekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            arLabel = new System.Windows.Forms.Label();
            nevLabel = new System.Windows.Forms.Label();
            uRLLabel = new System.Windows.Forms.Label();
            nevLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arakBindingNavigator)).BeginInit();
            this.arakBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arakDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boltokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // arLabel
            // 
            arLabel.AutoSize = true;
            arLabel.Location = new System.Drawing.Point(198, 337);
            arLabel.Name = "arLabel";
            arLabel.Size = new System.Drawing.Size(20, 13);
            arLabel.TabIndex = 4;
            arLabel.Text = "Ár:";
            // 
            // nevLabel
            // 
            nevLabel.AutoSize = true;
            nevLabel.Location = new System.Drawing.Point(198, 360);
            nevLabel.Name = "nevLabel";
            nevLabel.Size = new System.Drawing.Size(57, 13);
            nevLabel.TabIndex = 14;
            nevLabel.Text = "Bolt Neve:";
            // 
            // uRLLabel
            // 
            uRLLabel.AutoSize = true;
            uRLLabel.Location = new System.Drawing.Point(198, 389);
            uRLLabel.Name = "uRLLabel";
            uRLLabel.Size = new System.Drawing.Size(32, 13);
            uRLLabel.TabIndex = 16;
            uRLLabel.Text = "URL:";
            // 
            // nevLabel1
            // 
            nevLabel1.AutoSize = true;
            nevLabel1.Location = new System.Drawing.Point(198, 291);
            nevLabel1.Name = "nevLabel1";
            nevLabel1.Size = new System.Drawing.Size(82, 13);
            nevLabel1.TabIndex = 34;
            nevLabel1.Text = "Készülék Neve:";
            // 
            // arakBindingNavigator
            // 
            this.arakBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.arakBindingNavigator.BindingSource = this.arakBindingSource;
            this.arakBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.arakBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.arakBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.arakBindingNavigatorSaveItem});
            this.arakBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.arakBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.arakBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.arakBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.arakBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.arakBindingNavigator.Name = "arakBindingNavigator";
            this.arakBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.arakBindingNavigator.Size = new System.Drawing.Size(734, 25);
            this.arakBindingNavigator.TabIndex = 0;
            this.arakBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // arakBindingNavigatorSaveItem
            // 
            this.arakBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.arakBindingNavigatorSaveItem.Enabled = false;
            this.arakBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("arakBindingNavigatorSaveItem.Image")));
            this.arakBindingNavigatorSaveItem.Name = "arakBindingNavigatorSaveItem";
            this.arakBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.arakBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // arTextBox
            // 
            this.arTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arakBindingSource, "Ar", true));
            this.arTextBox.Enabled = false;
            this.arTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.arTextBox.Location = new System.Drawing.Point(290, 334);
            this.arTextBox.Name = "arTextBox";
            this.arTextBox.Size = new System.Drawing.Size(120, 20);
            this.arTextBox.TabIndex = 5;
            this.arTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nevTextBox
            // 
            this.nevTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arakBindingSource, "Boltok.Nev", true));
            this.nevTextBox.Enabled = false;
            this.nevTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevTextBox.Location = new System.Drawing.Point(290, 360);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(170, 20);
            this.nevTextBox.TabIndex = 15;
            // 
            // uRLTextBox
            // 
            this.uRLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arakBindingSource, "Boltok.URL", true));
            this.uRLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uRLTextBox.Location = new System.Drawing.Point(290, 389);
            this.uRLTextBox.Name = "uRLTextBox";
            this.uRLTextBox.ReadOnly = true;
            this.uRLTextBox.Size = new System.Drawing.Size(170, 20);
            this.uRLTextBox.TabIndex = 17;
            this.uRLTextBox.DoubleClick += new System.EventHandler(this.uRLTextBox_DoubleClick);
            // 
            // nevTextBox1
            // 
            this.nevTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arakBindingSource, "Termekek.Nev", true));
            this.nevTextBox1.Enabled = false;
            this.nevTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevTextBox1.Location = new System.Drawing.Point(290, 284);
            this.nevTextBox1.Multiline = true;
            this.nevTextBox1.Name = "nevTextBox1";
            this.nevTextBox1.Size = new System.Drawing.Size(170, 44);
            this.nevTextBox1.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Boltok";
            this.dataGridViewTextBoxColumn1.HeaderText = "Boltok";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Termekek";
            this.dataGridViewTextBoxColumn2.HeaderText = "Termekek";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // arakDataGridView
            // 
            this.arakDataGridView.AutoGenerateColumns = false;
            this.arakDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arakDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.arakDataGridView.DataSource = this.arakBindingSource;
            this.arakDataGridView.Location = new System.Drawing.Point(375, 74);
            this.arakDataGridView.Name = "arakDataGridView";
            this.arakDataGridView.Size = new System.Drawing.Size(259, 187);
            this.arakDataGridView.TabIndex = 35;
            // 
            // TermekListBox
            // 
            this.TermekListBox.FormattingEnabled = true;
            this.TermekListBox.Location = new System.Drawing.Point(75, 103);
            this.TermekListBox.Name = "TermekListBox";
            this.TermekListBox.Size = new System.Drawing.Size(180, 160);
            this.TermekListBox.TabIndex = 36;
            this.TermekListBox.SelectedIndexChanged += new System.EventHandler(this.TermekListBox_SelectedIndexChanged);
            // 
            // TermekTextBox
            // 
            this.TermekTextBox.Location = new System.Drawing.Point(75, 74);
            this.TermekTextBox.Name = "TermekTextBox";
            this.TermekTextBox.Size = new System.Drawing.Size(180, 20);
            this.TermekTextBox.TabIndex = 37;
            this.TermekTextBox.TextChanged += new System.EventHandler(this.TermekTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 42);
            this.label1.TabIndex = 38;
            this.label1.Text = "Válassza ki a terméket! A keresőbe írva tud tovább szűrni.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(360, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 42);
            this.label2.TabIndex = 38;
            this.label2.Text = "Válassza ki az értékesítőt!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(466, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 101);
            this.label3.TabIndex = 38;
            this.label3.Text = "A linkre duplán kattintva meg tudja nyitni a bolt weboldalát.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(417, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ft";
            // 
            // KedvezmenyButton
            // 
            this.KedvezmenyButton.Location = new System.Drawing.Point(25, 41);
            this.KedvezmenyButton.Name = "KedvezmenyButton";
            this.KedvezmenyButton.Size = new System.Drawing.Size(111, 48);
            this.KedvezmenyButton.TabIndex = 40;
            this.KedvezmenyButton.Text = "Kérek Kedvezményt!";
            this.KedvezmenyButton.UseVisualStyleBackColor = true;
            this.KedvezmenyButton.Click += new System.EventHandler(this.KedvezmenyButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.KedvezmenyButton);
            this.panel1.Location = new System.Drawing.Point(12, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 125);
            this.panel1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Kedvezmény:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "%";
            // 
            // KedvezmenyszazalekTextBox
            // 
            this.KedvezmenyszazalekTextBox.Enabled = false;
            this.KedvezmenyszazalekTextBox.Location = new System.Drawing.Point(49, 307);
            this.KedvezmenyszazalekTextBox.Name = "KedvezmenyszazalekTextBox";
            this.KedvezmenyszazalekTextBox.Size = new System.Drawing.Size(48, 20);
            this.KedvezmenyszazalekTextBox.TabIndex = 43;
            // 
            // KedvezmenykodTextBox
            // 
            this.KedvezmenykodTextBox.Enabled = false;
            this.KedvezmenykodTextBox.Location = new System.Drawing.Point(27, 353);
            this.KedvezmenykodTextBox.Name = "KedvezmenykodTextBox";
            this.KedvezmenykodTextBox.Size = new System.Drawing.Size(127, 20);
            this.KedvezmenykodTextBox.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Kedvezménykód:";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BoltFK";
            this.dataGridViewTextBoxColumn5.DataSource = this.boltokBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Nev";
            this.dataGridViewTextBoxColumn5.HeaderText = "BoltFK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "BoltID";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // boltokBindingSource
            // 
            this.boltokBindingSource.DataSource = typeof(Project.Boltok);
            // 
            // arakBindingSource
            // 
            this.arakBindingSource.DataSource = typeof(Project.Arak);
            // 
            // termekekBindingSource
            // 
            this.termekekBindingSource.DataSource = typeof(Project.Termekek);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(734, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TermekTextBox);
            this.Controls.Add(this.TermekListBox);
            this.Controls.Add(this.arakDataGridView);
            this.Controls.Add(nevLabel1);
            this.Controls.Add(this.nevTextBox1);
            this.Controls.Add(nevLabel);
            this.Controls.Add(this.nevTextBox);
            this.Controls.Add(uRLLabel);
            this.Controls.Add(this.uRLTextBox);
            this.Controls.Add(arLabel);
            this.Controls.Add(this.arTextBox);
            this.Controls.Add(this.arakBindingNavigator);
            this.Controls.Add(this.KedvezmenykodTextBox);
            this.Controls.Add(this.KedvezmenyszazalekTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.arakBindingNavigator)).EndInit();
            this.arakBindingNavigator.ResumeLayout(false);
            this.arakBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arakDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boltokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource arakBindingSource;
        private System.Windows.Forms.BindingNavigator arakBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton arakBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource termekekBindingSource;
        private System.Windows.Forms.BindingSource boltokBindingSource;
        private System.Windows.Forms.TextBox arTextBox;
        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.TextBox uRLTextBox;
        private System.Windows.Forms.TextBox nevTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView arakDataGridView;
        private System.Windows.Forms.ListBox TermekListBox;
        private System.Windows.Forms.TextBox TermekTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button KedvezmenyButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KedvezmenyszazalekTextBox;
        private System.Windows.Forms.TextBox KedvezmenykodTextBox;
        private System.Windows.Forms.Label label7;
    }
}