using System;
using System.Windows.Forms;

namespace LifeDecisionSupportSystem_FunctionBased
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        private bool IsNumeric(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }

        private string CheckAffordability(double budget, double cost)
        {
            if (cost <= budget * 0.5)
                return "Affordable";
            else if (cost <= budget)
                return "Affordable";
            else if (cost <= budget * 1.2)
                return "Critical";
            else
                return "Not Affordable";
        }

        private int ComputePriority(int importance, string urgency)
        {
            int urgencyWeight = 0;
            if (urgency == "Low")
                urgencyWeight = 1;
            else if (urgency == "Medium")
                urgencyWeight = 2;
            else if (urgency == "High")
                urgencyWeight = 3;

            return importance * urgencyWeight;
        }

        private string EvaluateRisk(string riskLevel)
        {
            if (riskLevel == "Low")
                return "Safe";
            else if (riskLevel == "Medium")
                return "Moderate";
            else
                return "High Risk";
        }

        private string GenerateDecision(string affordability, int priorityScore, string riskEvaluation)
        {
            if (affordability == "Not Affordable")
                return "Not Recommended";

            if (affordability == "Affordable" && priorityScore >= 20 && riskEvaluation == "Safe")
                return "Proceed Immediately";

            if (affordability == "Critical" || riskEvaluation == "High Risk")
                return "Delay Decision";

            if (riskEvaluation == "Moderate" || priorityScore < 10)
                return "Proceed with Caution";

            return "Proceed Immediately";
        }

        private string GenerateExplanation(string affordability, int priorityScore, string riskEvaluation, string decision)
        {
            string explanation = "";

            if (affordability == "Not Affordable")
                explanation += "The estimated cost exceeds your budget. ";
            else if (affordability == "Critical")
                explanation += "The cost is close to your budget limit. ";
            else
                explanation += "The cost is within your budget. ";

            if (priorityScore >= 20)
                explanation += "This decision has a high priority score. ";
            else if (priorityScore >= 10)
                explanation += "This decision has a moderate priority score. ";
            else
                explanation += "This decision has a low priority score. ";

            if (riskEvaluation == "High Risk")
                explanation += "The risk level is high, consider alternatives.";
            else if (riskEvaluation == "Moderate")
                explanation += "The risk is manageable but proceed carefully.";
            else
                explanation += "The risk level is low and safe to proceed.";

            return explanation;
        }

        private void DisplayResult(string affordability, int priorityScore, string riskEvaluation, string decision, string explanation)
        {
            lblAffordabilityResult.Text = affordability;
            lblPriorityResult.Text = priorityScore.ToString();
            lblRiskResult.Text = riskEvaluation;
            lblDecisionResult.Text = decision;
            lblExplanationResult.Text = explanation;

            if (decision == "Proceed Immediately")
                lblDecisionResult.ForeColor = System.Drawing.Color.DarkGreen;
            else if (decision == "Proceed with Caution")
                lblDecisionResult.ForeColor = System.Drawing.Color.DarkOrange;
            else if (decision == "Delay Decision")
                lblDecisionResult.ForeColor = System.Drawing.Color.DarkGoldenrod;
            else
                lblDecisionResult.ForeColor = System.Drawing.Color.DarkRed;
        }

        private void ResetForm()
        {
            txtBudget.Clear();
            txtCost.Clear();
            cboUrgency.SelectedIndex = -1;
            cboImportance.SelectedIndex = -1;
            cboRisk.SelectedIndex = -1;
            lblAffordabilityResult.Text = "-";
            lblPriorityResult.Text = "-";
            lblRiskResult.Text = "-";
            lblDecisionResult.Text = "-";
            lblDecisionResult.ForeColor = System.Drawing.Color.DarkBlue;
            lblExplanationResult.Text = "-";
            txtBudget.Focus();
        }

        private bool ValidateInputs()
        {
            if (IsEmpty(txtBudget.Text))
            {
                MessageBox.Show("Budget cannot be empty.", "Validation Error");
                txtBudget.Focus();
                return false;
            }
            if (!IsNumeric(txtBudget.Text))
            {
                MessageBox.Show("Budget must be a numeric value.", "Validation Error");
                txtBudget.Focus();
                return false;
            }
            if (IsEmpty(txtCost.Text))
            {
                MessageBox.Show("Estimated Cost cannot be empty.", "Validation Error");
                txtCost.Focus();
                return false;
            }
            if (!IsNumeric(txtCost.Text))
            {
                MessageBox.Show("Estimated Cost must be a numeric value.", "Validation Error");
                txtCost.Focus();
                return false;
            }
            if (cboUrgency.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an Urgency Level.", "Validation Error");
                return false;
            }
            if (cboImportance.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an Importance Level.", "Validation Error");
                return false;
            }
            if (cboRisk.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Risk Level.", "Validation Error");
                return false;
            }
            return true;
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                double budget = Convert.ToDouble(txtBudget.Text.Trim());
                double cost = Convert.ToDouble(txtCost.Text.Trim());
                string urgency = cboUrgency.SelectedItem.ToString();
                int importance = Convert.ToInt32(cboImportance.SelectedItem.ToString());
                string riskLevel = cboRisk.SelectedItem.ToString();

                string affordability = CheckAffordability(budget, cost);
                int priorityScore = ComputePriority(importance, urgency);
                string riskEvaluation = EvaluateRisk(riskLevel);
                string decision = GenerateDecision(affordability, priorityScore, riskEvaluation);
                string explanation = GenerateExplanation(affordability, priorityScore, riskEvaluation, decision);

                DisplayResult(affordability, priorityScore, riskEvaluation, decision, explanation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
