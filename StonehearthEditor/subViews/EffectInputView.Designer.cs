namespace StonehearthEditor.subViews
{
   partial class EffectInputView
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.typeLabel = new System.Windows.Forms.Label();
         this.valuesLabel = new System.Windows.Forms.Label();
         this.addValueButton = new System.Windows.Forms.Button();
         this.typeComboBox = new System.Windows.Forms.ComboBox();
         this.valuesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
         this.surfaceComboBox = new System.Windows.Forms.ComboBox();
         this.limitsTipLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // typeLabel
         // 
         this.typeLabel.AutoSize = true;
         this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.typeLabel.Location = new System.Drawing.Point(20, 11);
         this.typeLabel.Name = "typeLabel";
         this.typeLabel.Size = new System.Drawing.Size(48, 22);
         this.typeLabel.TabIndex = 0;
         this.typeLabel.Text = "kind:";
         // 
         // valuesLabel
         // 
         this.valuesLabel.AutoSize = true;
         this.valuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.valuesLabel.Location = new System.Drawing.Point(20, 64);
         this.valuesLabel.Name = "valuesLabel";
         this.valuesLabel.Size = new System.Drawing.Size(67, 22);
         this.valuesLabel.TabIndex = 1;
         this.valuesLabel.Text = "values:";
         // 
         // addValueButton
         // 
         this.addValueButton.Location = new System.Drawing.Point(291, 62);
         this.addValueButton.Name = "addValueButton";
         this.addValueButton.Size = new System.Drawing.Size(34, 24);
         this.addValueButton.TabIndex = 2;
         this.addValueButton.Text = "+";
         this.addValueButton.UseVisualStyleBackColor = true;
         // 
         // typeComboBox
         // 
         this.typeComboBox.FormattingEnabled = true;
         this.typeComboBox.Items.AddRange(new object[] {
            "CONSTANT",
            "RANDOM_BETWEEN",
            "RANDOM_BETWEEN_CURVES",
            "CURVE"});
         this.typeComboBox.Location = new System.Drawing.Point(95, 13);
         this.typeComboBox.Name = "typeComboBox";
         this.typeComboBox.Size = new System.Drawing.Size(190, 21);
         this.typeComboBox.TabIndex = 3;
         // 
         // valuesFlowPanel
         // 
         this.valuesFlowPanel.BackColor = System.Drawing.SystemColors.Control;
         this.valuesFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.valuesFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
         this.valuesFlowPanel.Location = new System.Drawing.Point(95, 64);
         this.valuesFlowPanel.Name = "valuesFlowPanel";
         this.valuesFlowPanel.Size = new System.Drawing.Size(190, 145);
         this.valuesFlowPanel.TabIndex = 6;
         // 
         // surfaceComboBox
         // 
         this.surfaceComboBox.FormattingEnabled = true;
         this.surfaceComboBox.Items.AddRange(new object[] {
            "POINT",
            "RECTANGLE"});
         this.surfaceComboBox.Location = new System.Drawing.Point(95, 13);
         this.surfaceComboBox.Name = "surfaceComboBox";
         this.surfaceComboBox.Size = new System.Drawing.Size(190, 21);
         this.surfaceComboBox.TabIndex = 7;
         this.surfaceComboBox.Visible = false;
         // 
         // limitsTipLabel
         // 
         this.limitsTipLabel.AutoSize = true;
         this.limitsTipLabel.Location = new System.Drawing.Point(97, 43);
         this.limitsTipLabel.Name = "limitsTipLabel";
         this.limitsTipLabel.Size = new System.Drawing.Size(0, 13);
         this.limitsTipLabel.TabIndex = 8;
         // 
         // EffectInputView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ControlLight;
         this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.Controls.Add(this.limitsTipLabel);
         this.Controls.Add(this.surfaceComboBox);
         this.Controls.Add(this.valuesFlowPanel);
         this.Controls.Add(this.typeComboBox);
         this.Controls.Add(this.addValueButton);
         this.Controls.Add(this.valuesLabel);
         this.Controls.Add(this.typeLabel);
         this.Name = "EffectInputView";
         this.Size = new System.Drawing.Size(363, 215);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label typeLabel;
      private System.Windows.Forms.Label valuesLabel;
      private System.Windows.Forms.Button addValueButton;
      private System.Windows.Forms.ComboBox typeComboBox;
      private System.Windows.Forms.FlowLayoutPanel valuesFlowPanel;
      private System.Windows.Forms.ComboBox surfaceComboBox;
      private System.Windows.Forms.Label limitsTipLabel;
   }
}
