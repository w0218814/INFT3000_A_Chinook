   M S B A M L   `   `   `  ����G  CINFT3000Demo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:INFT3000Demo.PagesINFT3000Demo.Pages  5      "    INFT3000Demo.Pages.Customers   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:INFT3000Demo.Pages     5        N� Title$  Tracks��5	       � 	Resources 5         customerViewSource��%   &	        �� 5   
   6<   5      .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   �� $��TRACKS PAGE��6   $��48(�6'   67   &   System.Windows.Controls.DataGrid  5   
   $	��300��6      AutoGenerateColumns$ False��5      !   EnableColumnVirtualization$
 True��6)   ��5       ��  �� Source# [     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   SortDirection 
Descending6E      Header$ Company Name��5      	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 6+   
   
IsReadOnly$

 True��6@   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *CompanyName+5   T     5      $ Contact Name��5      $	 SizeToHeader 6+   $

 True��6@    5   %   �� *ContactName+5   T     5      $ Address��5      $	 SizeToHeader 6&   $

 True��6;    5   %   �� *	Address+5   O     5      $
 City��5      $	 SizeToHeader 6#   $

 True��68    5   %   �� *City+5   L     5      $ Country��5      $	 SizeToHeader 6&   $

 True��6;    5   %   �� *	Country+5   O     5      $ PhoneAndFax��5      $	 SizeToHeader 6*   $

 True��6?    5   %   �� *PhoneAndFax+5   S   5!      �� 5"   
   -   5         ��Name$ 
SaveButton��5"      $
��Save��6%   6O   5%      5&      