using DevExpress.XtraEditors;
using LibraryApp.Business.Abstracts;
using LibraryApp.Business.Concretes;
using LibraryApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UI.Statistics
{
	public partial class frmStatistics : DevExpress.XtraEditors.XtraForm
	{
		private readonly IBookTransactionService _bookTransactionService;
		public frmStatistics(IBookTransactionService bookTransactionService)
		{
			InitializeComponent();
			_bookTransactionService = bookTransactionService;
			this.Load += frmStatistics_Load;

		}
		private void frmStatistics_Load(object sender, EventArgs e)
		{
			LoadStatistics();
		}
		private void LoadStatistics()
		{
			var statistics = _bookTransactionService.GetStatistics();
			gridControlStatistics1.DataSource = new List<StatisticsDto> { statistics };
			gridControlStatistic2.DataSource = new List<StatisticsDto> { statistics };
			gridViewStatistics1.BestFitColumns();
			gridViewStatistics2.BestFitColumns();

		}


	}
}