namespace FactoryMethod.Core
{
    public class ChartProviderFree : IChartProvider
    {
        public IChart GetChart()
        {
            IChart chart = new BarChart();
            return chart;
        }
    }
}
