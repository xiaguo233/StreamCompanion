﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace osu_StreamCompanion.Code.Modules.MapDataParsers.Parser1
{
    public partial class PatternList : UserControl
    {
        public PatternList()
        {
            InitializeComponent();
            dataGridView.SelectionChanged += DataGridViewOnSelectionChanged;
        }

        private void DataGridViewOnSelectionChanged(object sender, EventArgs eventArgs)
        {
            OutputPattern item = null;
            if (dataGridView.SelectedRows.Count > 0)
                item = (OutputPattern)dataGridView.SelectedRows[0].DataBoundItem;
            SelectedItemChanged?.Invoke(sender, item);
        }

        public void SetPatterns(BindingList<OutputPattern> patterns)
        {
            dataGridView.DataSource = patterns;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public EventHandler<OutputPattern> SelectedItemChanged;
    }
}
