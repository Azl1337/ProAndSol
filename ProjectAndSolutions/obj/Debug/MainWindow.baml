   M S B A M L   `   `   `  ����N  JProjectAndSolutions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectAndSolutionsProjectAndSolutions  5   	   $    ProjectAndSolutions.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ProjectAndSolutions     5   	    
  Window#��[  5   	     � Title$  
MainWindow��5	   	   $	��600��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $��90 �6   �� 5      $��* �6   .+�5   
   �� $��ProjectAndSolutions��6   $
��Left=�6/   $��Center=�6J   $��40 0 0 0q�5      $��48(�6&    
 akcent#���  64   �� 5   
   -   5         ��Name$ BtnDevisions��5      $"��Подраздленения��6'   $��Right=�6Z   $��Center=�6v   $��0 0 40 0q�5      $	��130��6#   �� 5   
   -   5        $ 
BtnWorkers��5      $��Работники��6%   $��Right=�6Q   $��Center=�6m   $��0 0 40 0q�5      $	��130��6#   $y�	Collapsed=�6/    � 5      -   5          �Name$ 	MainFrame��5      $��1��6'     � NavigationUIVisibility$ Hidden=�64   5      5      