namespace FactoryMethod.Core
{
    public class ChartProviderPaid : IChartProvider
    {
        public IChart GetChart()
        {
            IChart chart = new PieChart();
            return chart;
        }
    }
}
