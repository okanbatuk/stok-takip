﻿using LayFlatfunctions;
using System;

namespace StokTakip
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            sabitDegiskenler.vtsYolu = @"a";
            con.ConnectionString = sabitDegiskenler.vtsYolu;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();
            if (!f.isExit)
            {
                this.Close();
            }
        }

        private void btnCariHesaplar_Click(object sender, EventArgs e)
        {
            CariHesaplar f = new CariHesaplar();
            f.ShowDialog();
        }

        private void btnBirimler_Click(object sender, EventArgs e)
        {
            Birimler f = new Birimler();
            f.ShowDialog();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            Stok f = new Stok();
            f.ShowDialog();
        }

        private void btnCreateFatura_Click(object sender, EventArgs e)
        {
            Fatura f = new Fatura();
            f.ShowDialog();
        }
        private void btnFaturaList_Click(object sender, EventArgs e)
        {
            FaturaLists f = new FaturaLists();
            f.ShowDialog();
        }
    }
}