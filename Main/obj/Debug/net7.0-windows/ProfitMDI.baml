   M S B A M L   `   `   `  ����?  ;Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MainMain  5          Main.ProfitMDI   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:Main     5      -   5        
������ $	��758��5   B   .��5      ��   �� CornerRadius$  40��6   ._�5   
   �� $  30��6   $��4q�6#   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ FloralWhite��6#    � Offset$ 0Q�67   6D   5      ��5      �� 5      $	 0,1&�6&   $	 1,0&�67   .��5      � $ Beige��6#   $ 0Q�61   6>   5      ._�5      � $	��590��6   $	��750��6    $��Baskerville Old Face)�6,    � ColumnDefinitions 5      �� 5      6)    � RowDefinitions 5      �� 5       $��35 �6$   62   �� 5!      $��60 �6%   64   �� 5"      $	��390 �6$   64   �� 5#      $
��auto �6$   64   .+�5'      �� $��1��6    �� TextAlignment$ Center=�6)   
���**��$��45(�6S   $��0 10 0 0q�6a   6u   &   System.Windows.Controls.DataGrid  5(      -   5          Name$ 
GridProfit��5(      $��2��6/   	   AutoGenerateColumns$	 False��6<   $��26,66,24,89q�6X   $��16(�6m   
   Columns
 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 83 6-      Header$ 	Hall Name��68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *	Hall.Name+  5+      $
 Date��6-   $ 77 6V    6;   �� *B_Date+6V     5,      $ Customer Name��6-   $	 119 6o    6D   �� *Customer.Customer_Name+6o     5-      $ Total Charges��6-   $	 110 6c    6D   �� *
B_GrdTotal+6c     5.      $ 75 6-   $ Profit��68    6H   �� *Profit+  5/      $ 
Staff Name��6-   $	 120 6i    6A   �� *StaffBooking.S_Name+6i   51      �� 52       �� Orientation$ 
Horizontal=�6   $��3��66   $��Center=�6C   .+�54      �� $��0q�6   $��Delete Booking��55      
�������$��13(�57      $��Times New Roman)�58       � Cursor$
 Hand��59      $
��Bold"�5:      ��5<      �� 5=       �� 
TargetType" ��6$   .�5>   "   ��  �� Property � �� �� Value
 � ���6O    �� Triggers 5?   "   P� 5@   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5A   *   ��  � ��
 �**��6W   5B   '   5D      ��5F      �� 5G       �� 
TargetType" ��6.   .R�5H   "   �� $	��100��6)   $��40��65   $  20��5I   )   #��z��5J   )   ._�5K   &   �� $��Center=�67   $��Center=�6R   6q   5L   #   5M      5O      5P      �� 5Q      $��/Img/logoIcon.png��6   $��175,10,175,18q�63   $��2��6J   �� 5T      $��2��6   $ Center=�6)   
���**��$��45(�6S   $��	0,0,0,336q�6a   Profit List6�   5U      5W      5X      5Y      