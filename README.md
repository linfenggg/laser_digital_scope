the diagram :

form (main windows)
{
    group:com   ---usb connect
    {
        label-combobox:----port selcet
        label-combobox:-----baudrate select
        bottom-connect  : -----open/close control
    }
  
    group:update
    {
        textbox+buttom :---select the firmware (bin file)
        bottom:update ----start update
        packet lenght : ymodem-protocal-packet type 
        progressbar:  show the updating progress (0%-100%)
        
    }
  group:curve  ------for data visiable 
  {
      checkox*6 ---- for show/hide the serise in the chart
      bottom -save/export   for saving the data to text/excle file  (not implement yet)
      bottom-photo ---- save the chart to picture 
      bottom-capture ---control capture 
      
      gonging to implement
      (more feature: the capture period can select by user )
  }
  
      group:setting  -----user-operation  set the current/tempture of board 
      {
          ld:
          {
          checkbox: open/close the power-switch
          textbox for user writting  the target value
          botton  ---send to the board and execute it
          }
          pump:
          {
          same as above
          }
          
          ov
          {
              
          }
         
         
          textbox:show the real-time string received from board 
      
      }
  
      
      
     

}