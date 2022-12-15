


<h1 align = "center">S7_CSV_TXT_to_XLS</h1>
<div align="center">
<image src="https://github.com/Iv013/S7_CSV_to_XLS/blob/master/s7_CSv/Properties/1.jpg" 
       style="width:350px" />
 </div>      

<h2>Description</h2>
  <p  text-indent = "20px">The application is designed to generate reports in *.xlsm format from files of the CSV and TXT format. CSV files are generate from alarm logger scada system WINCC Simatic Siemens.TXT files are exported from the IFIX SCADA real-time messaging application developed by EMICON. </p>

  <p text-indenе= "20px"; >For generate a report in the format XLSM, used the Epplus library .</p>
 <h2>Where is used</h2>
    <p> This application is used to format the log of operational messages, which is exported from SCADA System in an unformatted form, where there is no coloring of messages by priority and the possibility of searching.</p>
       <div align="center">
          <image src="https://github.com/Iv013/hexlet-git/blob/main/%D0%94%D0%BE%20%D0%BF%D0%B5%D1%80%D0%BE%D0%B1%D1%80%D0%B0%D0%B7%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F.png" 
            style="width:450px" />
           <p>Unformatted message log</p>
     </div>    
      <div align="center">
  <image src="https://github.com/Iv013/hexlet-git/blob/main/%D0%BF%D0%BE%D1%81%D0%BB%D0%B5%20%D0%BF%D0%B5%D1%80%D0%BE%D0%B1%D1%80%D0%B0%D0%B7%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F.png" 
       style="width:450px" />
    <p>Formatted message log</p>
   </div> 
      <p>Additionally, when the log is generated, counted repeated messages   for  analysis and troubleshooting.</p>
     <div align="center">
  <image src="https://github.com/Iv013/hexlet-git/blob/main/sort.png" 
       style="width:450px" />
  </div>
     
     
<h2>Startup application</h2>
  <p>To run the application, you need to download the solution, run it in Visual Studio and compile the solution.</p>
 
 
 
 <h2>How it works</h2>
 <p>There are two application modes.</p>
  <ol> 
    <li>  Auto mode
      <ul>
        <li>  Select  (or drag and drop  on feald)  a folder for monitored new report files, and then restart the application  in <strong>hide mode</strong>.
When a new file with alarm messages appears in a folder in a non-editable format, File.Wathcher is triggered and he automatically  start method, that formats the text from the file and saves it in XLSM format.</li>
        </li>
      </ul>
    </li>
<br/>
 <div align="center">
   <image src="https://github.com/Iv013/hexlet-git/blob/main/WatcherFile.gif"  style="width:500px"  />
 </div>
 <br/>
   <li> Manual mode
     <ul>
        <li> Select (or drag and drop  on feald) an unformatted file  , and then click button   "Convert" is , after which is called a method  that formats the text from the file and saves it in XLSM format </li>
       <br/>
   <div align="center">
   <image src="https://github.com/Iv013/hexlet-git/blob/main/GenerateFile.gif"  style="width:500px"   />
 </div>
        <br/>
  <li>If there are many files that need to be formatted, you can do it all at once. It is necessary to expand the window and drag all the files into the ListBox, and then click the Convert button</li>
    <div align="center">
   <image src="https://github.com/Iv013/hexlet-git/blob/main/ManyFile.gif"  style="width:500px"   />
 </div>
  
  
  </ul>
   </li>
  </ol>
 
   
 
   
