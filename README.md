# How-to-format-TimeSpanAxis-label-based-on-axis-interval-in-WPF-SfChart
This sample demonstrate how to format TimeSpanAxis label based on axis interval in WPF (SfChart)
WPF SfChart provides support for formatting axis labels based on axis intervals in TimeSpanAxis. The LabelFormat Property can be used to apply predefined formatting types based on usages. This article explains how to format TimeSpanAxis label based on axis interval in WPF (SfChart)

##[Xaml]
````
<chart:SfChart>
            <chart:SfChart.DataContext>
                <local:ViewModel/>
            </chart:SfChart.DataContext>
            <chart:SfChart.PrimaryAxis>

                <chart:TimeSpanAxis Minimum="00:00:00" 
                                    EdgeLabelsDrawingMode="Shift" 
                                    Maximum="00:00:10" 
                                    LabelFormat="mm\:ss\:fff">
                    <chart:TimeSpanAxis.Header>
                        <Label FontWeight="Bold"  
                               Content="Time in (mm:ss:fff)"/>
                    </chart:TimeSpanAxis.Header>
                </chart:TimeSpanAxis>
            </chart:SfChart.PrimaryAxis>

            <chart:SfChart.SecondaryAxis  >
                <chart:NumericalAxis Minimum="50" Maximum="700" >
                    <chart:NumericalAxis.Header>
                        <Label Content="Distance in (meters)" 
                               FontWeight="Bold" />
                    </chart:NumericalAxis.Header>
                </chart:NumericalAxis>
            </chart:SfChart.SecondaryAxis>
            
            <chart:SfChart.Series>
                <chart:SplineSeries XBindingPath="Time" 
                                    Interior="Purple" 
                                    YBindingPath="Distance" 
                                    ItemsSource="{Binding Data}" >
                    <chart:SplineSeries.AdornmentsInfo>
                        <chart:ChartAdornmentInfo ShowLabel="True" />
                    </chart:SplineSeries.AdornmentsInfo>
                </chart:SplineSeries>
            </chart:SfChart.Series>
        </chart:SfChart>
````

##[C#]
````
  SfChart chart = new SfChart();
            this.DataContext = new ViewModel();

            TimeSpanAxis primaryAxis = new TimeSpanAxis()
            {
                Minimum = new TimeSpan(00, 00, 00),
                Maximum = new TimeSpan(00, 00, 10),
                LabelFormat = "mm\\:ss\\:fff",
                Header = new Label()
                {
                    Content = "Time in (mm:ss:fff)",
                    FontWeight = FontWeights.Bold,
                },
                EdgeLabelsDrawingMode = EdgeLabelsDrawingMode.Shift,

            };
            chart.PrimaryAxis = primaryAxis;

            NumericalAxis secondaryAxis = new NumericalAxis()
            {
                Minimum = 50,
                Maximum = 700,
                Header = new Label()
                {
                    Content = "Distance in (meters)",
                    FontWeight = FontWeights.Bold,
                },

            };
            chart.SecondaryAxis = secondaryAxis;

            SplineSeries series = new SplineSeries()
            {
                XBindingPath = "Time",
                YBindingPath = "Distance",
                ItemsSource = (new ViewModel()).Data,
                AdornmentsInfo = new ChartAdornmentInfo()
                {
                    ShowLabel = true,
                },
                Interior = new SolidColorBrush(Colors.Purple),
                
            };
            chart.Series.Add(series);
            this.Content = chart;
````
##Output
 
  ![Output](https://user-images.githubusercontent.com/105482474/211509266-b28301df-9f64-4c2b-8f79-e9cf258b2723.png)

##See Also

[Axis labels for TimeSpanAxis in WPF (SfChart)](https://help.syncfusion.com/wpf/charts/axis#axis-labels)
	
[How to display the axis labels in a particular format](https://www.syncfusion.com/kb/3318/how-to-display-the-axis-labels-in-a-particular-format-of-wpf-chart-sfchart)
	
[How to customize label formats of data-time axis during the interval transitions](https://www.syncfusion.com/kb/6940/how-to-customize-the-label-formats-of-date-time-axis-during-interval-transitions-in-wpf)

