   M S B A M L   `   `   `  ����@  <iq007, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:iq007.View
iq007.View  5          iq007.View.ListPupilsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:iq007.View     5        N� Title$  ListPupilsPage��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	Pupillist��5         AutoGenerateColumns .     
IsReadOnly . $	��0,1q�6l      HorizontalGridLinesBrush �	#FFB1B1B1   VerticalGridLinesBrush �	#FFB1B1B1   AlternatingRowBackground �	#FFE4E4E4$��16(�6�   $��Calibri Light)�6�      HeadersVisibility$ Column=�6  ��6B   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Фамилия��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 200 66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      ��  �� Path$ Surname�  5      $	 Имя��6%    5      �� $
 Name�6>     5      $	 Отчество��6%   $
 * 67    5      �� $ Midname�6A      ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  �� Property � �� �� Value$ Stretch=�6<   �� 5       � ��$
 Left=�6C   �� 5       � ��
 �<��63   �� 5       � ��
 �����63   �� 5       � ��$ 32(�61   �� 5       � ��$
 20,0q�60   6?   �� 5       � ��$	 1,0q�68   6F   �� 5       � ��
 �����64   5         	CellStyle 5!      �� 5"      *  $System.Windows.Controls.DataGridCell"  6    �� Triggers 5#      P� 5$       P� Property �@ 
IsSelected P� Value . . �5&      ��  � ��
 �����5'      �� 5(       � ��
 �   �5)      �� 5*       � ��
 �����5+      5,      .�5.      ��  � ��$ 20,0,0,0q�6/   5/      51      52      53      