   M S B A M L   `   `   `  ����  GeoMapSampleProject$    GeoMapSampleProject.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   � InfragisticsWPF4.Controls.Maps.XamGeographicMap.v18.2, Version=18.2.20182.137, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb� }InfragisticsWPF4.Controls.Charts.XamDataChart.v18.2, Version=18.2.20182.137, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cby uInfragisticsWPF4.Controls.Maps.XamMap.v18.2, Version=18.2.20182.137, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbd `InfragisticsWPF4.v18.2, Version=18.2.20182.137, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbv	 rInfragisticsWPF4.DataVisualization.v18.2, Version=18.2.20182.137, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb5ig$http://schemas.infragistics.com/xaml     	 5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   1  +Infragistics.Controls.Maps.XamGeographicMap  -   5        $��GeoMap��5
      (  "Infragistics.Controls.SeriesViewer'    OverviewPlusDetailPaneVisibility$ 	Collapsed=�6,   
���   �   Series 5      C  =Infragistics.Controls.Maps.GeographicProportionalSymbolSeries  5      -   5          Name$ SymbolSeries��5   8      LatitudeMemberPath$ Latitude��5   ,      LongitudeMemberPath$ 	Longitude��5   ,      MaximumMarkers$
 2200��5   ,      MarkerOutline
 ����    FillMemberPath$ 
SnowHeight��5   ,   	   
MarkerType$	 Square=�5   ,   )  #Infragistics.Controls.Charts.Series
   ItemsSource
 5   ,   �� *
SnowPoints+   RadiusScale 5      ,  &Infragistics.Controls.Charts.SizeScale  5         MaximumValue$ 10Q�6'      MinimumValue$ 10Q�69      IsLogarithmic .     LogarithmBase$ 2��6a      	FillScale 5      2  ,Infragistics.Controls.Charts.ValueBrushScale  5         MaximumValue$ 4Q�6-      MinimumValue$ 0Q�6>      IsLogarithmic .  -  'Infragistics.Controls.Charts.BrushScale   Brushes 5   "   " 	 Infragistics.BrushCollection  �� 5   &    �� Color$ 	#FF1AA1E2��66   �� 5   &   $ 	#FF4AC4FF��66   �� 5   &   $ 	#FFB5CC2E��66   �� 5   &   $ 	#FFFFD034��66   �� 5   &   $ 	#FFFC8612��66   �� 5    &   $ 	#FFED4840��66   �� 5!   &   $ 	#FF7D120D��66   5"   #   5$         ToolTip 5&      �� 5'      ._�5(      �� 
���iii�$��1q�6;   
�������._�5)   "   �� $��4q�6-   .+�5*   &   ��  �� Orientation$ 
Horizontal=�61   $
��Left=�6J   .+�5+   *   �� $��	Longitude��64   $��2q�6E   $
��Bold"�6P   �� 5,   *   
�������$��4,2,2,2q�6�   ��64   ��  �� Path$ Item.Longitude� �� StringFormat$	 0.0��6�   5-   '   �� 5.   &   $ 
Horizontal=�61   $
��Left=�6J   .+�5/   *   �� $��Latitude��64   
�������$��2q�6\   $
��Bold"�6g   �� 50   *   
�������$��4,2,2,2q�6�   ��64   �� $ Item.Latitude�$	 0.0��6�   51   '   52   #   53      54      56      58      59      5:      