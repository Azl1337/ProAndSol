   M S B A M L   `   `   `  ����N  JProjectAndSolutions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ProjectAndSolutions.FramesProjectAndSolutions.Frames  5      ,    &ProjectAndSolutions.Frames.WorkersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:ProjectAndSolutions.Frames     5      -   5          N� Title$  WorkersPage��5	         
background N� 
Background# [  6C   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      � $��0��6   $��Stretch=�5      .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $0��*Введите ФИО для поиска:��6    �� 5      -   5         ��Name$ 
TBoxSearch��5   6   $	��234��6   $��25��6*   $��5 2 0 2q�5    ?   5!      �� 5$      $ 
Horizontal=�6   .+�5%      �� $=��7Сортировать по Подразделению:��6    �� 5'      -   5         ��Name$ ComboDevisions��5'   +   $	��191��6    �� DisplayMemberPath$ DevName��5)      $��5 2 0 4q�67   5*      5+      � 5.      $��0��6   $��1��6%   $��Stretch=�5/      .+�51      �� $ 
Horizontal=�6   .+�52      �� $)��#Принятие на работу ��6    �� 53      -   5         ��Name$ ChBoxEmployment��53       �� 54      $ ��     Увольнение ��6    �� 55      -   5        $ 	ChBoxFire��55      57      �� 59      $ 
Horizontal=�6   .+�5:      �� $��от: ��6    (  "System.Windows.Controls.DatePicker  5;      -   5        	  Name$	 DPickerFrom��5;   !   $	��133��66   
   DisplayDate$
 
1900-01-01��6s   �� 5<      $��до: ��6      5=      -   5        $	 	DPickerTo��5=   !   $	��133��64   6@   �� 5>      -   5         ��Name$ BtnClearDate��5>      $��Очистить��63   $��5 0 0 0q�6`   5?      5@      5A      &   System.Windows.Controls.DataGrid  5C   
   -	   5          Name$ DGridWorkers��5C      $��1��6)      AutoGenerateColumns .     
IsReadOnly .    Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	ID_Worker+6O     5F      $ ФИО��6=   $ 5* 6J    6%   �� *FIO+6J     5G      $# Табельный номер��6D   $ 5* 6]    6%   �� *
ServiceNum+6]     5H      $ Должность��6B   $ 5* 6U    6%   �� *
Position+6U     5I      $  Подразделение��6J   $ 5* 6a    6%   �� *Devision.DevName+6a     5J      $ Email��6?   $ 5* 6N    6%   �� *Email+6N     5K      $ Телефон��6F   $ 5* 6W    6%   �� *TelephoneNum+6W     5L      $ Дата приема��6C   $ 5* 6X    6%   �� *	DateOfAdd+6X     5M      $# Дата увольнения��6C   $ 5* 6\    6%   �� *	DateOfDis+6\     5N      $% Состояние записи��6C   $ 5* 6]    6%   �� *	GetStatus+6]   4  .System.Windows.Controls.DataGridTemplateColumn  5P      $
 auto 6)   $  Редактировать��66      CellTemplate 5Q      �� 5R      .R�5S      �� $
 Edit��6%   -
   5        $ ��Редактировать��5S   3   $	��100��6`   5T      5V        5X      $
 auto 6)   $ Уволить��66    5Y      �� 5Z      .R�5[      �� $
 Fire��6%   -   5        $��Уволить��5[   3   $	��100��6\   5\      5^      5`      �� 5b   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   .+�5c      �� -   5        $ btnAdd��5c      $��Добавить��6%   $��5q�6M   5d      5e      5f      