   M S B A M L   `   `   `  ����  R02_BeamsRebar)    #R02_BeamsRebar.View.SectionAreaView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      -   5          >�Name$  SectionAreaUC��5
      
�������.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *LoadSectionAreaCommand+   CommandParameter 6O   ��  �� ElementName$ 
MainWindow��5       � 	Resources 5       �� MergedDictionaries	 �� Source�� 5   
    5      �� 5      $'	 !./../Library/Resource/Styles.xaml?�6%   6R   %    5      .��5      � $��5 0 0 0q�6   
 � ColumnDefinitions
 5   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��60 �6   6*   �� 5      6   .+�5#   
   � $��1��6   $��0��6   $��0 5 5 0q�6,   .+�5$      �� ��6   �� *$"SelectedSectionAreaModel.NameStart+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�.��5%      �� -   5         ��Name$ canvasStart��5%      5&      5'      5(      � 5)   
   $��1��6   $��1��6   $��5 5 5 0q�6,   .+�5*      �� ��6   �� *%#SelectedSectionAreaModel.NameMiddle+$ PropertyChanged=�$ TwoWay=�.��5+      �� -   5        $ 	canvasMid��5+      5-      5.      5/      � 50   
   $��1��6   $��2��6   $��5 5 0 0q�6,   .+�51      �� ��6   �� *#!SelectedSectionAreaModel.NamelEnd+$ PropertyChanged=�$ TwoWay=�.��52      �� -   5        $ 	canvasEnd��52      6.   53      54      � 56   
   $��0��6   $��0��6   $��3��6,   $��0 5 0 5q�6@   .+�57      � 
 58      �� 59      $
��0.5* �6'   66   �� 5:      $
��0.5* �6'   66   �� 5;      $
��0.5* �6'   66   �� 5<      $
��0.5* �6'   66   �� 5=      6)   �� 5>      $
��0.5* �6'   66   �� 5?      6)   �� 5@      $
��0.5* �6'   66   �� 5A      6)   �� 5B      $
��0.5* �6'   66   .+�5D      �� $��0��6      DataGridTextBlockCenter#��[  6,   $
��Span��6]   $��20(�6i   6y   �� 5E      $��1��6   $��30��6+     ComboBoxStyle#��[ 67    �� DisplayMemberPath$ 
NumberSpan��5F   P   ��6   �� *BeamsModel.SectionAreaModels+ �� SelectedItem 5G      �� *SelectedSectionAreaModel+$ PropertyChanged=�$ TwoWay=� �� SelectedIndex 5H      �� *+)BeamsModel.SelectedIndexModel.SectionSpan+ 5I        5J      $ SelectionChanged��6)   . 5K         64   �� *SelectionChangedSpanCommand+ 6d   �� $ 
MainWindow��5L      5N      �� 5O      $��3��6   #��[  6,   $��Start��6]   $��20(�6j   6z   �� 5P      $��4��6   #��[  6,   $��WrapWithOverflow=�6�   ��6]   �� *&$SelectedSectionAreaModel.DetailStart+$ PropertyChanged=�$ TwoWay=�6�   �� 5Q      $��5��6   #��[  6,   $��Middle��6]   $��20(�6k   6{   �� 5R      $��6��6   #��[  6,   $��WrapWithOverflow=�6�   ��6]   �� *'%SelectedSectionAreaModel.DetailMiddle+$ PropertyChanged=�$ TwoWay=�6�   �� 5S      $��7��6   #��[  6,   $	��End��6]   $��20(�6h   6x   �� 5T      $��8��6   #��[  6,   $��WrapWithOverflow=�6�   ��6]   �� *$"SelectedSectionAreaModel.DetailEnd+$ PropertyChanged=�$ TwoWay=�6�   5V      5W      5X      5Y      