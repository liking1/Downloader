   M S B A M L   `   `   `  ����E  ADownloader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Downloader
Downloader  5   	       Downloader.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Downloader     5   	     � Title$  
Downloader��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��61* �6   �� 5      $	��61* �6   �� 5      $
��292* �6   .+�5   
   � $��0��6   $��Center=�6!   $��Center=�6>   .+�5      �� $��Input file to download: ��6   
���� ��$��30(�6L   �� 5      -   5         ��Name$ tbPath��5      $��30(�6&   $	��300��64   5      �� 5   
   -   5         ��Name$ lbOutput��5      $��2��6$   $��5q�61   ��5      �� 5      .R�5      ]� $��5q�6    .+�5      �� $
��Bold"�6    ��62   �� *
FileName+6Q   �� 5      $��10(�6    .��6.   From64   �� 5      $
��Bold"�6    ��62   �� *
FolderName+6S   �� 5      $��Right=�6$   $��Center=�6;   �� 5      �6"   �� *
Progress+ �� 5      .�6"   %6%   5      � 5      $	��100��6&   $��5q�65    � Value 6@   �� *
Progress+6]   5      5       5"      � 5#   
   $��1��6   $��70��6!   .+�5$      �� -   5        $��btnDownload��5$   �   $	��180��6   $��45��6!   $��10q�6-   $��Download��69   $��25(�6L   
�������
��� � �6�   �� 5%      -   5        $��	btnCancel��5%   |   $	��180��6   $��45��6!   $��10q�6-   $��Cancel��69   $��25(�6J   
�������
���  ��6�   �� 5&      -   5        $��btnPause��5&   |   $	��175��6   $��45��6!   $��10q�6-   $��Pause��69   $��25(�6I   
�������
�������6�   �� 5'      -   5        $��	btnRename��5'   q   $	��155��6   $��45��6!   $��10q�6-   $��Remove��69   $��25(�6J   
�������6�   5(      5)      5*      