private void BtnAdd_Click(object sender, EventArgs e)
{
    try
    {
        string name = txtName.Text.Trim();
        string contact = txtContact.Text.Trim();
        string category = cmbCategory.SelectedItem.ToString().Substring(0, 1);
        double fee = double.Parse(txtFee.Text);
        bool isValid = chkIsValid.Checked;

        if (fee < 0)
            throw new Exception("Fee cannot be negative.");

        Participant p = new Participant(name, category, contact, fee, isValid);
        festivalManager.AddParticipant(p);

        lstParticipants.Items.Add(p.GetDetails());
    }
    catch (FormatException)
    {
        MessageBox.Show("Fee must be a number.");
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
}
