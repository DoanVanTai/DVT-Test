   M S B A M L   `   `   `  ����H  D44.ViewRename, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TGLTGL  5   
       TGL.ViewRenameWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   !tglclr-namespace:TGL     5   
   -   5          �Name$  
MainWindow��5   	    � Title$ TGL Solutions��5	   	    � 
ResizeMode$ NoResize=�5
   	    � ShowInTaskbar .  � WindowStartupLocation$ CenterScreen=�5   	   $��734.77��5   
   $	��910��6    � Topmost .  � 	Resources 5       �� Source�� 5   
   $$ ../../WPF/Resource/Styles.xaml?�6   %    .��5      �� .+�5   
   �  � RowDefinitions 5      �� 5      $	��620 �6    	 � ColumnDefinitions	 5      �� 5      $	��300 �6#   �� 5      $
��Auto �6#   �� 5      $��2* �6#   .+�5"      ]� $��0��6   ��. .+�5%      R�    TGL.CustomTreeView
   EnableMultiSelect
 .    TreeViewStyle#���   5(      ��5%      �� *AllViewsExtension+   SelectedItems 5&      �� *SelectedViewsExtension+��5*      �� 5+       �� DataType$ tgl:ViewExtension��63    �� ItemsSource 5,   3   �� *	ViewItems+.R�5-      ��  �� Orientation$ 
Horizontal=�6)   $��20��5.   )   .+�5/   "   �� -   5          CheckBoxStyle#���  5/   +    d� 	IsChecked 50   +   �� *
IsSelected+51   +   �� 53   "   $��Center=�54   ,   ��53   ,   �� *Name+54   ,   55      57      5:      5<      5>      ]� 5@   
   ��.  $��40��6*   .+�5A      �� -   5        $��Right=�5A        ButtonStyle#���  5B      $��CANCEL��5C      5D      �� 5E      -   5        $��Right=�5E      #���  5F      $��OK��5G      5H      5I      5K      5M      