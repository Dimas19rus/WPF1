   M S B A M L   `   `   `  ����I  EWpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApplicationWpfApplication  5   	       WpfApplication.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfApplication     5   	     � Title$  Notepad��5   	   $	��350��6   $	��500��6&    � WindowStartupLocation$ CenterScreen=�62   .��5	      � .+�5
   
   �� -   5         ��Name$ TextBox��5
       � Language$ ru-Ru�6$   $��5,25,5,5q�66   o� 5   
   -   5         o�Name$
 Menu��5      $	��Top=�6   $
��Left=�66   .@�5      m� $
��File��6   .@�5      m� -   5        $
��Open��5      $
��Left=�6)   $��139.2��6D   6R   m� 5      -   5        $
��Save��5      $
��Left=�6)   $��139.2��6D   6R   m� 5      -   5        $��
Save as...��5      $
��Left=�6/   $��139.2��6J   6X   5      m� 5      $��	Functions��6   .@�5      m� -   5        $
��Undo��5      $
��Left=�6)   $��139.2��6D   6R   m� 5      -   5        $
��Redo��5      $
��Left=�6)   $��139.2��6D   6R   m� 5      -   5        $
��Copy��5      $
��Left=�6)   $��139.2��6D   6R   m� 5      -	   5        $	��Cut��5      $
��Left=�6(   $��139.2��6C   6Q   m� 5      -
   5        $��Pastle��5      $
��Left=�6+   $��139.2��6F   6T   m� 5      -   5        $��
Select all��5      $
��Left=�6/   $��139.2��6J   6X   5      m� 5      $��Settings��6   .@�5      �� -   5         ��Name$ CheckBox��5      $��Hyphenation��6-   $��80��6C   6N   �� 5      -   5        $ 	CheckBox1��5      $��Spelling��6.   $��80��6A   6L   �� 5      -   5         ��Name$ 	TextBlock��5      $��Language spelling:��6/   $
��Wrap=�6I   �� 5      -   5         ��Name$ ComboBox��5       �� SelectedIndex$ 0��6-   .@�5      �� -   5        $��Russian��5   #   $
��Left=�65   6P   �� 5      -   5        $��English��5   #   $
��Left=�65   6P   5       5"      5#      �� 5$   
   -   5        	 ��Name$	 Button��5$      $	��End��6!   $��0,2,2,0q�6F   $��Right=�6W   $��25��6s   $��17��6~   $	��Top=�6�   5%      5&      