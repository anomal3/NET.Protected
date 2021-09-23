using dnlib.DotNet;
using Protect.NET.Helpers;
using Protect.NET.Protections;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Protect.NET.Forms
{
    public partial class frmMain : Form
    {
        // hello
        List<IProtection> protections = new List<IProtection>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }
        private void runProtections()
        {
            foreach (IProtection protection in protections)
                protection.Protect();
        }
        private void loadProtections()
        {
            //protections.Add(new Proxy());
            protections.Add(new Constants());
            protections.Add(new Renamer());
        }

        private string PathToPack;
        private const string ABRACADABRA = "Click mouse here to select file crypt";
        private void tbPath_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPath.Text) || tbPath.Text == ABRACADABRA)
            {
                ofd.Title = "CRYPT";
                ofd.Filter = "Только EXE (*.exe)|*.exe";
                if (DialogResult.OK == ofd.ShowDialog())
                {
                    PathToPack = ofd.FileName;
                    tbPath.Text = PathToPack;

                    var naming = PathToPack.Substring(PathToPack.LastIndexOf("\\") + 1);
                    naming = naming.Substring(0, naming.LastIndexOf('.'));
                    lOutF.Text = $"Output name: {PathToPack.Substring(0, PathToPack.LastIndexOf("\\")) + '\\' + naming + "_crypt.exe"}";
                }
            }
        }

        private void bCrypt_Click(object sender, EventArgs e)
        {
            Globals.asm = AssemblyDef.Load(PathToPack);


            Generator.type = Generator.sType.Unreadable;


            loadProtections();
            runProtections();
            var naming = PathToPack.Substring(PathToPack.LastIndexOf("\\") + 1);
            naming = naming.Substring(0, naming.LastIndexOf('.'));
            Globals.asm.Write(PathToPack.Substring(0, PathToPack.LastIndexOf("\\")) + '\\' + naming + "_crypt.exe");
            
            MessageBox.Show("MISSION COMPLETE!",
                null,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Environment.Exit(0);
        }
    }
}
