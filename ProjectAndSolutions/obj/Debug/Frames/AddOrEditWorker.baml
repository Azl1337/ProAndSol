   M S B A M L   `   `   `  ����N  JProjectAndSolutions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ProjectAndSolutions.FramesProjectAndSolutions.Frames  5      0    *ProjectAndSolutions.Frames.AddOrEditWorker   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:ProjectAndSolutions.Frames     5      -   5          N� Title$  AddOrEditWorker��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� $��ФИО ��6   �� 5   
   $#��Табельный номер��6   $��1��6*   �� 5   
   $��Должность��6   $��2��6$   �� 5   
   $ ��Подразделение��6   $��3��6(   �� 5    
   $��Email��6   $��4��6    �� 5!   
   $��Телефон��6   $��5��6"   �� 5#   
   -   5         ��Name$ 	TBoxLogin��5#      $��0��6:   $��1��6G   $	��5 5q�6W   ��6%   �� *FIO+6W   �� 5$   
   -   5        $ TBoxPassword��5$      $��1��6D   $��1��6Q   $	��5 5q�6a   ��6(   �� *
ServiceNum+6a   �� 5%   
   -   5        $ TBoxLastName��5%      $��2��6B   $��1��6O   $	��5 5q�6_   ��6(   �� *
Position+6_   �� 5&   
   -   5         ��Name$ CBoxWorkerDevision��5&      $��3��6Q   $��1��6^   $	��5 5q�6n    �� DisplayMemberPath$ DevName��6{    �� SelectedValuePath$ ID_Devision��6�    �� SelectedItem 6/   �� *
Devision+6�   �� 5'   
   -   5        $ TBoxPatronymic��5'      $��4��6A   $��1��6N   $	��5 5q�6^   ��6*   �� *Email+6^   �� 5(   
   -   5        $ TBoxCityAccommodation��5(      $��5��6O   $��1��6\   $	��5 5q�6l   ��61   �� *TelephoneNum+6l   � 5)   
   $��6��6   $��1��6    5*      �� 5+      $	��210 �6#   �� 5,      �� 5-      $	��230 �6#   5/      �� 51   
   $��9��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��Center=�6g   .+�52      �� -   5        	 ��Name$	 BtnOK��52      $��OK��6$   61   �� 53      -	   5        $	 	BtnCancel��53      $��Cancel��6(   $��5 0 5 0q�6P   54      55      56      