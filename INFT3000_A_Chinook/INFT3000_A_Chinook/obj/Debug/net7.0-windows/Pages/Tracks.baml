   M S B A M L   `   `   `  ����M  IINFT3000_A_Chinook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:INFT3000_A_Chinook.PagesINFT3000_A_Chinook.Pages  5      M+clr-namespace:INFT3000_A_Chinook.ConvertersINFT3000_A_Chinook.Converters  5      %    INFT3000_A_Chinook.Pages.Tracks   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:INFT3000_A_Chinook.Pages     5      B
converters+clr-namespace:INFT3000_A_Chinook.Converters     5        N� Title$  Tracks��5
       � 	Resources 5         tracksViewSourceB   <INFT3000_A_Chinook.Converters.MillisecondsToMinutesConverter " MillisecondsToMinutesConverter=   7INFT3000_A_Chinook.Converters.BytesToMegabytesConverter  BytesToMegabytesConverter  BackgroundColor �� Color  AccentColor  	TextColor  SecondaryTextColor  DetailBackgroundColor �� 
TargetType �� Property �� Value  DetailBorderStyle��%`  &	        &	      &	 &     &	 9     &	 Z     &	 {     &	 �     &	 �     '�� �     7  '�� "    7  7  7  '�� �    7  7  &	 -    7  �� 5   
   6     5   
   64     5   
   6/   �� 5   
   $ #1DB954��62   �� 5   
   $ #121212��6.   �� 5   
   $ #FFFFFF��6,   �� 5   
   $ #B3B3B3��65   �� 5   
   $ #198844��68   �� 5   
   " ��6   .�5      ��  � ��8   6+   5      �� 5   
   " ��6   .�5      ��  � ��8   6+   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5       � ��$ 2q�60   5      �� 5   
   " ��6   .�5      ��  � ��8   6+   �� 5        � ��8  6+   5!      �� 5"   
   " ��6   .�5#      ��  � ��8   6+   �� 5$       �@��CornerRadius$ 5��6-   �� 5%       �@��Padding$ 5q�6(   5&      5'      .��5)      � $��10q�6   #��[ 6    � RowDefinitions 5*   
   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   �� 5-      $��* �6   .+�50   
   �� $��0��6   $��TRACKS��6!   $��48(�6/   $
��Left=�51      $��Center=�6/   #��[ 52      �� 54   
   -   5         ��Name$ TrackSearchTextBox��54      $��1��6.   $��Search by track name...��55      $��5q�59      $��3q�6   �� 5;   
   $��2��5<      $��Stretch=�5=      $��0,0,10,0q�5>      ��5;      ��  �� Source# [  ��5?      �� 5@      .R�5A      �� $��5q�6!   .+�5B      �� 	 �� Orientation$	 Vertical=�6%   $��5q�6<   .+�5C      �� $
��Bold"�6>   ��6(   �� *Name+6>   �� 5D      $��Italic$�6]   ��6(   �� *
Composer+
 �� TargetNullValue$
 Unknown��6]   5E      �� 5G      $
��Left=�6%   $��5,0,5,5q�6@   .+�5H      �� -   5        #��[ 5H   %   ._�5I   "   �� $	 
Horizontal=�6-   .+�5J   &   �� $	��5,0q�5K   0   #��[ 6=   ��5J   0   �� *Milliseconds+ �� 	Converter# [ 5K   =   �� 5L   &   $	��5,0q�5M   0   #��[ 6=   ��5L   0   �� *Bytes+# [ 5M   =   �� 5N   &   $	��5,0q�5O   0   #��[ 6=   ��5N   0   �� *	UnitPrice+ �� StringFormat$ ${0:F2}��5O   =   5P   #   5Q      5R      5S      5T      5V      5W      5X      