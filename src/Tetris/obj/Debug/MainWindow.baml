   M S B A M L   `   `   `  ����A  =Tetris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TetrisTetris  5   	       Tetris.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Tetris     5   	     � Title$  Tetris��5   	   $
��1020��6   $	��800��6&   .��5	      � .+�5
   
   � -   5         �Name$ 
TetrisGrid��5
      $
��Left=�6#   $	��920��6>   $��	10,0,0,10q�6K   $��Bottom=�6^   $	��400��6y    � ShowGridLines . 5      �� 5   
   $��Tetris��6   $
��Left=�6!   $��10,1,0,0q�6<   $	��Top=�6N   $��42��6f   $	��400��6r   $��24(�6~   $��
Wide Latin)�6�   � 5   
   -   5        $ PreviewGrid��5      $	��200��6$   $	��200��60   $��
0,123,80,0q�6=   $��Right=�6Q   $	��Top=�6m    .  � RowDefinitions 5      �� 5      $��50 �6    �� 5      $��50 �6    �� 5      $��50 �6    �� 5      $��50 �6     � ColumnDefinitions 5      �� 5      $��50 �6#   �� 5      $��50 �6#   �� 5      $��50 �6#   �� 5      $��50 �6#   5      �� 5   
   $��Score:��6   $��Right=�6!   $��
0,356,80,0q�6=   $	��Top=�6Q   $	��200��6i   $��32��6u   �� 5   
   -   5         ��Name$ Label_Score��5      $�� ��6%   $��Right=�60   $��49��6L   $��
0,413,80,0q�6X   $	��Top=�6l   $	��200��6�   �� 5   
   $��
Next item:��6   $��Right=�6%   $��48��6A   $��	0,59,80,0q�6M   $	��Top=�6`   $	��200��6x   �� 5   
   -   5         ��Name$ 	Btn_Start��5      $��Start��6$   $
��Left=�64   $��67��6O   $��512,890,0,0q�6[   $	��Top=�6p   $	��200��6�   $��36(�6�   $��
Wide Latin)�6�   6�   5      5       