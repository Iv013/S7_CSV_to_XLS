


<h1 align = "center">S7_CSV_TXT_to_XLS</h1>
<div align="center">
<image src="https://github.com/Iv013/S7_CSV_to_XLS/blob/master/s7_CSv/Properties/1.jpg"
       style="width:350px" />
 </div>      

<h2>Description</h2>
  <p style="text-indent: 25px;">The application is designed to generate reports in *.xlsm format from CSV or TXT files. CSV files are created via Alarm Logger application WINCC Simatic Siemens SCADA system. TXT files are exported from the IFIX SCADA real-time alarm messaging application developed by EMICON. </p>

  <p style="text-indent: 25px;"; >For generating a report in the format XLSM I used Epplus library .</p>
 <h2>Where it is used</h2>
    <p> This application is used to format the log of alarm messages, which is exported from SCADA System in an unformatted text. This output has no color of messages by priority and no search options.</p>
       <div align="center">
          <image src="https://github.com/Iv013/hexlet-git/blob/main/Unformatted.png"
            style="width:450px" />
           <p>Unformatted message log</p>
     </div>    
      <div align="center">
  <image src="https://github.com/Iv013/hexlet-git/blob/main/formatted.png"
       style="width:450px" />
    <p>Formatted message log</p>
   </div>
      <p style="text-indent: 25px;">Additionally, when the log is generated, it counts repeated messages for analysis and troubleshooting.</p>
     <div align="center">
  <image src="https://github.com/Iv013/hexlet-git/blob/main/sort.png"
       style="width:450px" />
  </div>


<h2>Startup application</h2>
  <p style="text-indent: 25px;">To run the application, you need to download the solution, to run it in Visual Studio and to compile the solution.</p>



 <h2>How it works</h2>
 <p>There are two application modes.</p>
  <ol>
    <li>  Auto mode
      <ul>
        <li> Select (or drag and drop on a field) a folder for monitored new report files, and then restart the application in hide mode. When a new file with alarm messages appears in a folder in a non-editable format, File.Wathcher is triggered and he automatically starts a method then formats the text from the file and saves it in XLSM format.</li>
        </li>
      </ul>
    </li>
<br>
 <div align="center">
   <image src="https://github.com/Iv013/hexlet-git/blob/main/WatcherFile.gif"  style="width:500px"  />
 </div>
 <br>
   <li> Manual mode
     <ul>
        <li> Select (or drag and drop on a field) an unformatted file , and then click button "Convert" then a method is called and it formats the text from the file and saves it as XLSM file. </li>
       <br>
   <div align="center">
   <image src="https://github.com/Iv013/hexlet-git/blob/main/GenerateFile.gif"  style="width:500px"   />
 </div>
        <br>
  <li>If you have many files that are needed to be formatted, you can do it all at once. It is necessary to expand the window and drag all the files into the ListBox, and then click the Convert button</li>
    <div align="center">
   <image src="https://github.com/Iv013/hexlet-git/blob/main/ManyFile.gif"  style="width:500px"   />
 </div>


  </ul>
   </li>
  </ol>
