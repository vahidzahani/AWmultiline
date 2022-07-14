using System;
using cAlgo.API;
using cAlgo.API.Internals;
using cAlgo.API.Indicators;
using cAlgo.Indicators;
//vahid.zahani@gmail.com
namespace cAlgo
{
    [Indicator(IsOverlay = true, AccessRights = AccessRights.None)]
    public class AWMultiline : Indicator
    {
        [Parameter(DefaultValue = 100)]
        public int StepPips { get; set; }

        [Parameter(DefaultValue = 0.0)]
        public double Parameter { get; set; }


        [Output("Main")]
        public IndicatorDataSeries Result { get; set; }





        protected override void Initialize()
        {

            var stackPanel = new StackPanel 
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                BackgroundColor = Color.Aqua,
                Opacity = 0.5
            };

            var button = new Button 
            {
                Text = "DRaw Line",
                Margin = 10
            };
            button.Click += Button_Click;

            stackPanel.AddChild(button);
            Chart.AddControl(stackPanel);


        }
        private void Button_Click(ButtonClickEventArgs obj)
        {

            //Chart.DrawTrendLine("trenddraw", Chart.Bars.Last(55).Low, Bars.ClosePrices, Chart.Bars.Last(0).Low, Bars.ClosePrices, "red");
            var trendLine = Chart.DrawTrendLine("trendline_" + DateTime.Now.ToString(), Chart.FirstVisibleBarIndex + 100, Bars.HighPrices[Chart.LastVisibleBarIndex], Chart.LastVisibleBarIndex, Bars.HighPrices[Chart.LastVisibleBarIndex], Color.Red, 4, LineStyle.Solid);
            trendLine.IsInteractive = true;





        }
        public override void Calculate(int index)
        {

        }






    }
}


