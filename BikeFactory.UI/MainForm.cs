using BikeFactory.Business;
using BikeFactory.Business.Enums;
using BikeFactory.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = BikeFactory.Business.Enums.Color;

namespace BikeFactory.UI
{
    public partial class MainForm : Form
    {
        private List<Bike> listofbikes = BikesXMLdata.Load();
        private bool therearesavechanges = false;

        public object MessageBoxButton { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            RefreshDisplayList();
        }

        #region Support Methods
        private Bike? Findbikebyserialnumber(int serialnumber)
        {
           Bike? bikefound = null;
            foreach (var bike in listofbikes)
            {
                if (bike.Serialnumber == serialnumber)
                {
                    bikefound = bike;
                    break;
                }

            }
            return bikefound;
        }
        private void RefreshDisplayList()
        {
            lstbikes.Items.Clear();
            foreach (var bikes in listofbikes)
            {
                bool include = false;
                if (rbAll.Checked)
                    include = true;
                else if (rbMountain.Checked && bikes is MountainBike)
                    include = true;
                else if (rbRoad.Checked && bikes is RoadBikes)
                    include = true;

                if (include)
                {
                    lstbikes.Items.Add(bikes.ToString());

                }
            }
        }
        private bool AllFieldsareok()
        {
            if (cbBikeType.Text == "")
            {
                MessageBox.Show("BikeType is required!","Warning",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else if (txtserialnumber.Text == "")
            {
                MessageBox.Show("Serial number is required!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtName.Text=="")
            {
                MessageBox.Show("Name is required!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(txtModel.Text == ""||!Validator.ValidateModel(txtModel.Text))
            {
                MessageBox.Show("Model is required and it must contain 5 characters only",
                    "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbColor.Text == "")
            {
                MessageBox.Show("Color is required!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtyear.Text == ""||!Validator.Validateyear(txtyear.Text))
            {
                MessageBox.Show("Manufactured Year is required! and it must be 4 numeric digits",
                    "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbBikeType.Text == "Mountain" && cbSuspensiontype.Text=="")
            {
                MessageBox.Show("Suspension Type is required", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbBikeType.Text == "Road" && cbTireType.Text == "")
            {
                MessageBox.Show("Tire Type is required", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!AllFieldsareok())
            {
                return;
            }
            else if (!Validator.ValidateUniquesn(txtserialnumber.Text, listofbikes))
            {
                MessageBox.Show("This serial number is already exists", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
            if(Convert.ToInt32(txtyear.Text) > 2022)
            {
                MessageBox.Show("Invalid Year!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Convert.ToInt32(txtyear.Text) < 1990)
            {
                MessageBox.Show("Bike must be manufactured after the year 1990!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Bike bikestoadd;
            if (cbBikeType.Text == "Mountain")
            {
                EsuspensionType suspensiontype;
                if (cbSuspensiontype.Text == "Front")
                    suspensiontype = EsuspensionType.Front;
                else if(cbSuspensiontype.Text =="Rear" )
                    suspensiontype = EsuspensionType.Dual;
                else
                    suspensiontype = EsuspensionType.Rear;

                bikestoadd = new MountainBike(suspensiontype);
                //skateboardtoadd = new ElectricSkateboard();

            }

            else
            {
                ETireType tiretype;
                if (cbBikeType.Text == "Communter")
                    tiretype = ETireType.Commuter;
                else if (cbBikeType.Text == "Gravel")
                    tiretype = ETireType.Gravel;
                else
                    tiretype = ETireType.Regular;

                bikestoadd = new RoadBikes(tiretype);
            }
            bikestoadd.Serialnumber = Convert.ToInt32(txtserialnumber.Text);
           bikestoadd.Name = txtName.Text;
            bikestoadd.Year = Convert.ToInt32(txtyear.Text);
            bikestoadd.Model = txtModel.Text;

            if (cbColor.Text == "Blue")
                bikestoadd.Color = Color.Blue;
            else if (cbColor.Text == "Green")
               bikestoadd.Color = Color.Green;
            else if (cbColor.Text == "Orange")
                bikestoadd.Color = Color.Orange;


            listofbikes.Add(bikestoadd);

            cbBikeType.SelectedIndex = -1;
            txtserialnumber.Text = "";
            txtName.Text = "";
            txtModel.Text = "";
            cbColor.SelectedIndex = -1;
            txtyear.Text = "";
            cbSuspensiontype.SelectedIndex = -1;
            cbTireType.SelectedIndex = -1;
            txtoriginialserialnumber.Text = "";

            RefreshDisplayList();
            therearesavechanges = true;

            MessageBox.Show("The Bike has been added", "Information",
                MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

       

        private void cbBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbBikeType.Text == "Mountain")
            {
                cbSuspensiontype.Enabled = true;
                cbTireType.Enabled = false;

                cbSuspensiontype.SelectedIndex = 0;
                cbTireType.SelectedIndex = -1;
            }

            else
            {
                cbSuspensiontype.Enabled = false;
                cbTireType.Enabled = true;

                cbSuspensiontype.SelectedIndex = -1;
                cbTireType.SelectedIndex = 0;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {

            RefreshDisplayList();
            lstbikes.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void rbMountain_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
            lstbikes.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void rbRoad_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplayList();
            lstbikes.Enabled = false;
            btnRemove.Enabled = false;
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtserialnumber.Text == "" || !Validator.ValidateId(txtserialnumber.Text))
            {
                MessageBox.Show("Serial number is required and should be numeric",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int serialnum = Convert.ToInt32(txtserialnumber.Text);
            var bikefound = Findbikebyserialnumber(serialnum);
            if (bikefound == null)
            {
                MessageBox.Show("Bike not found!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string message = bikefound.ToString().Replace(",", Environment.NewLine);
            MessageBox.Show(message, "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lstbikes.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a Bike!","Warning",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }
            var result = MessageBox.Show("Do you really want to remove?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            listofbikes.RemoveAt(index);
            lstbikes.Items.RemoveAt(index);
            therearesavechanges = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!AllFieldsareok())
                return;
            else if (txtserialnumber.Text != txtoriginialserialnumber.Text)
            {
                if (!Validator.ValidateUniquesn(txtserialnumber.Text, listofbikes))
                {
                    MessageBox.Show("This serial number is already exists", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int sn = Convert.ToInt32(txtserialnumber.Text);

            var bikeToUpdate = Findbikebyserialnumber(sn);

            if (bikeToUpdate is MountainBike && cbBikeType.Text == "Road" ||
                bikeToUpdate is RoadBikes && cbBikeType.Text == "Mountain")
            {
                MessageBox.Show("It is not possible to change the type. Alternatively ," +
                    "you may remove and add this skateboard with a different type","Error" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (cbBikeType.Text == "Mountain")
            {
                if (cbSuspensiontype.Text == "Front")
                    (bikeToUpdate as MountainBike).EsuspensionType = EsuspensionType.Front;
                else if (cbSuspensiontype.Text == "Rear")
                    (bikeToUpdate as MountainBike).EsuspensionType = EsuspensionType.Rear;
                else
                    (bikeToUpdate as MountainBike).EsuspensionType |= EsuspensionType.Dual;
                //(skateboardToUpdate as ElectricSkateboard).Ebraketype = (EBrakeType)Enum.Parse(typeof(EBrakeType), cbBreakType.Text)
            }
            else
            {
                if (cbTireType.Text == "Gravel")
                    (bikeToUpdate as RoadBikes).ETiretype = ETireType.Gravel;
                else if (cbTireType.Text == "Commuter")
                    (bikeToUpdate as RoadBikes).ETiretype = ETireType.Commuter;
                else if(cbTireType.Text == "Regular") 
                    (bikeToUpdate as RoadBikes).ETiretype = ETireType.Regular;
                
            }

            bikeToUpdate.Serialnumber = sn;
            bikeToUpdate.Name = txtName.Text;
           bikeToUpdate.Model = txtModel.Text;
            bikeToUpdate.Year = Convert.ToInt32(txtyear.Text);

            if (cbColor.Text == "Blue")
                bikeToUpdate.Color = Color.Blue;
            else if (cbColor.Text == "Green")
                bikeToUpdate.Color = Color.Green;
            else
                bikeToUpdate.Color = Color.Orange;

            RefreshDisplayList();
            therearesavechanges = true;
            MessageBox.Show("The Bike has been updated", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtoriginialserialnumber.Text = "";
        }

        private void lstbikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbikes.SelectedIndex < 0)
                return;
            var bikes = listofbikes[lstbikes.SelectedIndex];
            if (bikes is MountainBike)
            {
                cbBikeType.SelectedIndex = 0;
                var bikeasmountain = (MountainBike)bikes;
                cbSuspensiontype.SelectedIndex = (int)bikeasmountain.EsuspensionType;
            }
            else
            {
                cbBikeType.SelectedIndex = 1;
                var bikeasroad = (RoadBikes)bikes;
                cbTireType.SelectedIndex = (int)bikeasroad.ETiretype;
            }

            txtserialnumber.Text = bikes.Serialnumber.ToString();
            txtoriginialserialnumber.Text = txtserialnumber.Text;
            txtName.Text = bikes.Name;
            txtModel.Text = bikes.Model;
            cbColor.SelectedIndex = (int)bikes.Color;
            txtyear.Text = bikes.Year.ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //var result = MessageBox.Show("Do you want to exit?", "Confirmation",
            //   MessageBoxButtons.YesNo,
            //   MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //    Application.Exit();
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            BikesXMLdata.Save(listofbikes);
            therearesavechanges = false;

            MessageBox.Show("The list of Bikes has been saved",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            

            if (therearesavechanges)
            {

                var res = MessageBox.Show("Do you want to save data before exit?", "Confirmation",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    BikesXMLdata.Save(listofbikes);
                    //Application.Exit();
                    e.Cancel = false;

                }
                else if (res == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }

            }

            else
            {
                var ans = MessageBox.Show("Do you really want to exit?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    e.Cancel = false;
                    //Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }

            }

            if (!e.Cancel)
            {
                Application.Exit();
            }
        }
    }
}
