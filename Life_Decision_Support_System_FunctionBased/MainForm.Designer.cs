namespace LifeDecisionSupportSystem_FunctionBased
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.lblSystemDesc = new System.Windows.Forms.Label();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblUrgency = new System.Windows.Forms.Label();
            this.cboUrgency = new System.Windows.Forms.ComboBox();
            this.lblImportance = new System.Windows.Forms.Label();
            this.cboImportance = new System.Windows.Forms.ComboBox();
            this.lblRisk = new System.Windows.Forms.Label();
            this.cboRisk = new System.Windows.Forms.ComboBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblAffordabilityLabel = new System.Windows.Forms.Label();
            this.lblAffordabilityResult = new System.Windows.Forms.Label();
            this.lblPriorityLabel = new System.Windows.Forms.Label();
            this.lblPriorityResult = new System.Windows.Forms.Label();
            this.lblRiskLabel = new System.Windows.Forms.Label();
            this.lblRiskResult = new System.Windows.Forms.Label();
            this.lblDecisionLabel = new System.Windows.Forms.Label();
            this.lblDecisionResult = new System.Windows.Forms.Label();
            this.lblExplanationLabel = new System.Windows.Forms.Label();
            this.lblExplanationResult = new System.Windows.Forms.Label();
            this.grpInputs.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTitle.Location = new System.Drawing.Point(31, 18);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(482, 38);
            this.lblSystemTitle.TabIndex = 0;
            this.lblSystemTitle.Text = "Life Decision Support System";
            this.lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSystemDesc
            // 
            this.lblSystemDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.lblSystemDesc.Location = new System.Drawing.Point(31, 56);
            this.lblSystemDesc.Name = "lblSystemDesc";
            this.lblSystemDesc.Size = new System.Drawing.Size(482, 20);
            this.lblSystemDesc.TabIndex = 1;
            this.lblSystemDesc.Text = "Smart Analysis. Better Decisions.";
            this.lblSystemDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblBudget);
            this.grpInputs.Controls.Add(this.txtBudget);
            this.grpInputs.Controls.Add(this.lblCost);
            this.grpInputs.Controls.Add(this.txtCost);
            this.grpInputs.Controls.Add(this.lblUrgency);
            this.grpInputs.Controls.Add(this.cboUrgency);
            this.grpInputs.Controls.Add(this.lblImportance);
            this.grpInputs.Controls.Add(this.cboImportance);
            this.grpInputs.Controls.Add(this.lblRisk);
            this.grpInputs.Controls.Add(this.cboRisk);
            this.grpInputs.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInputs.Location = new System.Drawing.Point(31, 92);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(482, 197);
            this.grpInputs.TabIndex = 0;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Input Fields";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(25, 27);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(48, 14);
            this.lblBudget.TabIndex = 0;
            this.lblBudget.Text = "Budget:";
            // 
            // txtBudget
            // 
            this.txtBudget.Font = new System.Drawing.Font("Arial", 9F);
            this.txtBudget.Location = new System.Drawing.Point(274, 25);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(186, 21);
            this.txtBudget.TabIndex = 0;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(25, 61);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(90, 14);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "Estimated Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCost.Location = new System.Drawing.Point(274, 59);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(186, 21);
            this.txtCost.TabIndex = 1;
            // 
            // lblUrgency
            // 
            this.lblUrgency.AutoSize = true;
            this.lblUrgency.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgency.Location = new System.Drawing.Point(25, 97);
            this.lblUrgency.Name = "lblUrgency";
            this.lblUrgency.Size = new System.Drawing.Size(83, 14);
            this.lblUrgency.TabIndex = 2;
            this.lblUrgency.Text = "Urgency Level:";
            // 
            // cboUrgency
            // 
            this.cboUrgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrgency.Font = new System.Drawing.Font("Arial", 9F);
            this.cboUrgency.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cboUrgency.Location = new System.Drawing.Point(274, 93);
            this.cboUrgency.Name = "cboUrgency";
            this.cboUrgency.Size = new System.Drawing.Size(186, 23);
            this.cboUrgency.TabIndex = 2;
            // 
            // lblImportance
            // 
            this.lblImportance.AutoSize = true;
            this.lblImportance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportance.Location = new System.Drawing.Point(25, 131);
            this.lblImportance.Name = "lblImportance";
            this.lblImportance.Size = new System.Drawing.Size(136, 14);
            this.lblImportance.TabIndex = 3;
            this.lblImportance.Text = "Importance Level (1-10):";
            // 
            // cboImportance
            // 
            this.cboImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImportance.Font = new System.Drawing.Font("Arial", 9F);
            this.cboImportance.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboImportance.Location = new System.Drawing.Point(274, 127);
            this.cboImportance.Name = "cboImportance";
            this.cboImportance.Size = new System.Drawing.Size(186, 23);
            this.cboImportance.TabIndex = 3;
            // 
            // lblRisk
            // 
            this.lblRisk.AutoSize = true;
            this.lblRisk.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisk.Location = new System.Drawing.Point(25, 165);
            this.lblRisk.Name = "lblRisk";
            this.lblRisk.Size = new System.Drawing.Size(64, 14);
            this.lblRisk.TabIndex = 4;
            this.lblRisk.Text = "Risk Level:";
            // 
            // cboRisk
            // 
            this.cboRisk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRisk.Font = new System.Drawing.Font("Arial", 9F);
            this.cboRisk.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cboRisk.Location = new System.Drawing.Point(274, 161);
            this.cboRisk.Name = "cboRisk";
            this.cboRisk.Size = new System.Drawing.Size(186, 23);
            this.cboRisk.TabIndex = 4;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.BackColor = System.Drawing.Color.LightGreen;
            this.btnEvaluate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEvaluate.Location = new System.Drawing.Point(401, 302);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(90, 23);
            this.btnEvaluate.TabIndex = 5;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = false;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCoral;
            this.btnReset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(305, 302);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblAffordabilityLabel);
            this.grpResults.Controls.Add(this.lblAffordabilityResult);
            this.grpResults.Controls.Add(this.lblPriorityLabel);
            this.grpResults.Controls.Add(this.lblPriorityResult);
            this.grpResults.Controls.Add(this.lblRiskLabel);
            this.grpResults.Controls.Add(this.lblRiskResult);
            this.grpResults.Controls.Add(this.lblDecisionLabel);
            this.grpResults.Controls.Add(this.lblDecisionResult);
            this.grpResults.Controls.Add(this.lblExplanationLabel);
            this.grpResults.Controls.Add(this.lblExplanationResult);
            this.grpResults.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.grpResults.Location = new System.Drawing.Point(31, 331);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(482, 271);
            this.grpResults.TabIndex = 1;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Evaluation Results";
            // 
            // lblAffordabilityLabel
            // 
            this.lblAffordabilityLabel.AutoSize = true;
            this.lblAffordabilityLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffordabilityLabel.Location = new System.Drawing.Point(25, 29);
            this.lblAffordabilityLabel.Name = "lblAffordabilityLabel";
            this.lblAffordabilityLabel.Size = new System.Drawing.Size(77, 14);
            this.lblAffordabilityLabel.TabIndex = 0;
            this.lblAffordabilityLabel.Text = "Affordability:";
            // 
            // lblAffordabilityResult
            // 
            this.lblAffordabilityResult.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffordabilityResult.Location = new System.Drawing.Point(166, 25);
            this.lblAffordabilityResult.Name = "lblAffordabilityResult";
            this.lblAffordabilityResult.Size = new System.Drawing.Size(294, 18);
            this.lblAffordabilityResult.TabIndex = 1;
            this.lblAffordabilityResult.Text = "-";
            this.lblAffordabilityResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPriorityLabel
            // 
            this.lblPriorityLabel.AutoSize = true;
            this.lblPriorityLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityLabel.Location = new System.Drawing.Point(25, 62);
            this.lblPriorityLabel.Name = "lblPriorityLabel";
            this.lblPriorityLabel.Size = new System.Drawing.Size(80, 14);
            this.lblPriorityLabel.TabIndex = 2;
            this.lblPriorityLabel.Text = "Priority Score:";
            // 
            // lblPriorityResult
            // 
            this.lblPriorityResult.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityResult.Location = new System.Drawing.Point(166, 58);
            this.lblPriorityResult.Name = "lblPriorityResult";
            this.lblPriorityResult.Size = new System.Drawing.Size(294, 18);
            this.lblPriorityResult.TabIndex = 3;
            this.lblPriorityResult.Text = "-";
            this.lblPriorityResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRiskLabel
            // 
            this.lblRiskLabel.AutoSize = true;
            this.lblRiskLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiskLabel.Location = new System.Drawing.Point(25, 94);
            this.lblRiskLabel.Name = "lblRiskLabel";
            this.lblRiskLabel.Size = new System.Drawing.Size(64, 14);
            this.lblRiskLabel.TabIndex = 4;
            this.lblRiskLabel.Text = "Risk Level:";
            // 
            // lblRiskResult
            // 
            this.lblRiskResult.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiskResult.Location = new System.Drawing.Point(166, 90);
            this.lblRiskResult.Name = "lblRiskResult";
            this.lblRiskResult.Size = new System.Drawing.Size(294, 18);
            this.lblRiskResult.TabIndex = 5;
            this.lblRiskResult.Text = "-";
            this.lblRiskResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDecisionLabel
            // 
            this.lblDecisionLabel.AutoSize = true;
            this.lblDecisionLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecisionLabel.Location = new System.Drawing.Point(25, 130);
            this.lblDecisionLabel.Name = "lblDecisionLabel";
            this.lblDecisionLabel.Size = new System.Drawing.Size(98, 18);
            this.lblDecisionLabel.TabIndex = 6;
            this.lblDecisionLabel.Text = "Final Decision:";
            // 
            // lblDecisionResult
            // 
            this.lblDecisionResult.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecisionResult.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDecisionResult.Location = new System.Drawing.Point(166, 126);
            this.lblDecisionResult.Name = "lblDecisionResult";
            this.lblDecisionResult.Size = new System.Drawing.Size(294, 22);
            this.lblDecisionResult.TabIndex = 7;
            this.lblDecisionResult.Text = "-";
            this.lblDecisionResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExplanationLabel
            // 
            this.lblExplanationLabel.AutoSize = true;
            this.lblExplanationLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanationLabel.Location = new System.Drawing.Point(25, 163);
            this.lblExplanationLabel.Name = "lblExplanationLabel";
            this.lblExplanationLabel.Size = new System.Drawing.Size(85, 18);
            this.lblExplanationLabel.TabIndex = 8;
            this.lblExplanationLabel.Text = "Explanation:";
            // 
            // lblExplanationResult
            // 
            this.lblExplanationResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExplanationResult.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanationResult.Location = new System.Drawing.Point(15, 190);
            this.lblExplanationResult.Name = "lblExplanationResult";
            this.lblExplanationResult.Size = new System.Drawing.Size(445, 65);
            this.lblExplanationResult.TabIndex = 9;
            this.lblExplanationResult.Text = "-";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 621);
            this.Controls.Add(this.lblSystemTitle);
            this.Controls.Add(this.lblSystemDesc);
            this.Controls.Add(this.grpInputs);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEvaluate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life Decision Support System";
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblSystemDesc;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblUrgency;
        private System.Windows.Forms.ComboBox cboUrgency;
        private System.Windows.Forms.Label lblImportance;
        private System.Windows.Forms.ComboBox cboImportance;
        private System.Windows.Forms.Label lblRisk;
        private System.Windows.Forms.ComboBox cboRisk;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblAffordabilityLabel;
        private System.Windows.Forms.Label lblAffordabilityResult;
        private System.Windows.Forms.Label lblPriorityLabel;
        private System.Windows.Forms.Label lblPriorityResult;
        private System.Windows.Forms.Label lblRiskLabel;
        private System.Windows.Forms.Label lblRiskResult;
        private System.Windows.Forms.Label lblDecisionLabel;
        private System.Windows.Forms.Label lblDecisionResult;
        private System.Windows.Forms.Label lblExplanationLabel;
        private System.Windows.Forms.Label lblExplanationResult;
    }
}
