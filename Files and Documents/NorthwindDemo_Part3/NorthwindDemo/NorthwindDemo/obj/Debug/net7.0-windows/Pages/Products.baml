   M S B A M L   `   `   `  ����G  CINFT3000Demo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:INFT3000Demo.PagesINFT3000Demo.Pages  5      !    INFT3000Demo.Pages.Products   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:INFT3000Demo.Pages     5        N� Title$  Products��5	       � 	Resources 5         productsViewSource��%   &	        �� 5   
   6<   5      .��5      �� .+�5   
   �� $��ALBUMS PAGE��6   &   System.Windows.Controls.DataGrid  5   
   $	��300��6      AutoGenerateColumns$ False��5      !   EnableColumnVirtualization$
 True��6!   ��5       ��  �� Source# [     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   SortDirection 
Descending6C      Header$ 
Product ID��5         Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6!   	   
IsReadOnly$
	 True��66   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5   %   �� *	ProductId+5   J     5      $ Product Name��5      $ SizeToHeader 6#   $
	 True��68   
 5   %   �� *ProductName+5   L     5      $ 
Unit Price��5      $ SizeToHeader 6!   $
	 True��66   
 5   %   �� *	UnitPrice+5   J   5      5      5      