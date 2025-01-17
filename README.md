# Customize-the-Legend-in-MAUI-Cartesian-Charts

This sample demonstrates how to add and customize legend in the MAUI Cartesian Charts control within a .NET MAUI application.

## Sample

```xaml
<chart:SfCartesianChart x:Name="chart">

    <chart:SfCartesianChart.Title>
        <Label Text="Blood Type Distribution Among Population" FontAttributes="Bold" HorizontalTextAlignment="Center" FontSize="16" />
    </chart:SfCartesianChart.Title>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis PlotOffsetStart="5" PlotOffsetEnd="5"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis PlotOffsetEnd="10">
            <chart:NumericalAxis.LabelStyle>
                <chart:ChartAxisLabelStyle LabelFormat="0'%"/>
            </chart:NumericalAxis.LabelStyle>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.YAxes>

    <chart:SfCartesianChart.Legend>
        <chart:ChartLegend>
            <chart:ChartLegend.ItemTemplate>
                <DataTemplate>
                    <StackLayout Orientation="Horizontal">
                        <Rectangle HeightRequest="7" Margin="10" 
                                   WidthRequest="20" Background="{Binding IconBrush}"/>
                        <Label Text="{Binding Text}" Margin="3"/>
                    </StackLayout>
                </DataTemplate>
            </chart:ChartLegend.ItemTemplate>
        </chart:ChartLegend>
    </chart:SfCartesianChart.Legend>

    <chart:StackingLineSeries ItemsSource="{Binding BloodType}" Label="O+"
                              XBindingPath="Country" YBindingPath="OType" 
                              Fill="DodgerBlue" ShowMarkers="True"
                              LegendIcon="SeriesType"/>

    <chart:StackingLineSeries ItemsSource="{Binding BloodType}" Label="A+"
                              XBindingPath="Country" YBindingPath="AType" 
                              Fill="Orange" ShowMarkers="True"
                              LegendIcon="SeriesType"/>

    <chart:StackingLineSeries ItemsSource="{Binding BloodType}" Label="B+"
                              XBindingPath="Country" YBindingPath="BType" 
                              Fill="Green" ShowMarkers="True"
                              LegendIcon="SeriesType"/>
</chart:SfCartesianChart>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.