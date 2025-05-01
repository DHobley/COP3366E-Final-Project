ComboBox cmbCategory = new ComboBox();
cmbCategory.Items.AddRange(new string[] { "M - Music", "D - Dance", "A - Art", "C - Culinary", "S - Sample Serving Sizes" });

Button btnAdd = new Button();
btnAdd.Text = "Add Participant";
btnAdd.Click += BtnAdd_Click;

ListBox lstParticipants = new ListBox();
