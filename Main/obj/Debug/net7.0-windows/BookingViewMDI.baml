   M S B A M L   `   `   `  ����?  ;Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MainMain  5          Main.BookingViewMDI   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:Main     5      -   5        
������ $	��758��5   >   .��5
      ��   �� CornerRadius$  40��6   ._�5   
   �� $  30��6   $��4q�6#   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ FloralWhite��6#    � Offset$ 0Q�67   6D   � 5      $ FloralWhite��6#   $	 0.5Q�67   6F   5      ��5      �� 5      $	 0,1&�6&   $	 1,0&�67   .��5      � $ Beige��6#   $ 0Q�61   6>   5      ._�5      � $	��590��6   $	��750��6    $��Baskerville Old Face)�6,    � ColumnDefinitions 5      �� 5      6)    � RowDefinitions 5      �� 5       $��35 �6$   62   �� 5!      $��60 �6%   64   �� 5"      $	��171 �6$   64   �� 5#      $	��219 �6$   �� 5$      $
��auto �6$   64   .+�5(      �� $��1��6    �� TextAlignment$ Center=�6)   
���**��$��45(�6S   $��0,10,0,0q�6a   Booking List6�   &   System.Windows.Controls.DataGrid  5)      -   5          Name$ BookingListDg��5)      $��2��62   	   AutoGenerateColumns$	 False��6?   $��26,66,24,89q�6[   $��16(�6p   $��2��6�   
   Columns
 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Header$ Customer��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Customer.Customer_Name+6j     5,      $ 83 6-   $ 	Hall Name��68    6K   �� *	Hall.Name+  5-      $  Date��6-   $ 77 6W    6<   �� *B_Date+6W     5.      $ 75 6-   $ 
Hall Price��68    6L   �� *
Hall.Price+  5/      $ Total Charges��6-   $ 99 6c    6D   �� *
B_GrdTotal+6c     50      $ 80 6-   $ Advance��68    6I   �� *	B_Advance+  51      $ 65 6-   $ Balance��68    6I   �� *	B_Balance+  52      $ Staff��6-   $	 120 6d    6<   �� *StaffBooking.S_Name+6d   54      �� 55       �� Orientation$ 
Horizontal=�6   $��4��66   $��Center=�6C   .+�57      �� -   5        $��0q�57      $��Delete Booking��58      
�������$��13(�5:      $��Times New Roman)�5;       � Cursor$
 Hand��5<      $
��Bold"�5=      ��5?      �� 5@       �� 
TargetType" ��6$   .�5A   "   ��  �� Property � �� �� Value
 � ���6O    �� Triggers 5B   "   P� 5C   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5D   *   ��  � ��
 �**��6W   5E   '   5G      ��5I      �� 5J       �� 
TargetType" ��6.   .R�5K   "   �� $	��100��6)   $��40��65   $  20��5L   )   #��z��5M   )   ._�5N   &   �� $��Center=�67   $��Center=�6R   6q   5O   #   5P      5R      5S      5U      5W      5X      5Y      