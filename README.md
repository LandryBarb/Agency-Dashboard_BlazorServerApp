# Agency-Dashboard_BlazorServerApp
 
 ![home](https://user-images.githubusercontent.com/71806398/159093738-14e7047b-9883-4280-bc96-17f0514c98e5.png)

<h2>
  Devlog - 2022-03-18
  </h2>
  <p>
  Started build of Entertainment Agency Dashboard. The goal is to create a dashboard for Admin users to Create and Modify their clients information across the agency.
  </p>
  <h2>
  Client Specifications
  </h2>
  <ul>
  <li>
  Create,  Read, Update, Delete clients from database
    </li>
  <li>
    Indentify minors(under the age of 18) to meet Union/non-union child labor regulations and to seek parental approval on audtion submissions
  </li>
   <li>
     Show if a client is ready to be submitted for auditions by verifying they have an updated headshot, their minor status if applicable
  </li>
  </ul>
  
  <h4>
  Tech Specifications:
  </h4>
<ul>
  <li>
  Blazor Server App for on-site server 
    </li>
  <li>
    Bootstrap UI framework for initial design 
    <ul>
      <li>
      To be revaluated after initial client approval of layout and color scheme - Potential custom design system
        </li>
      </ul>
    
  </li>
  </ul>
  
  <h3>
  Recent Work 
  </h3>
  <ul>
  <li>
  Base Server project template implemented. 
  </li>
  <li>
    Created Client class with custom methods for verifying minor status
  </li>
  <li>
    Create method for verifying Client can be submitted for work
  </li>
 
 <li>
  6:37pm - Refactor Edit/Delete buttons into separate components using Attribute Splatting
 </li>
  </ul>


<h2>
  Devlog - 2022-03-19 - 8:46am
  </h2>
   <ul>
  <li>
  Installed Mudblazor to test layout and design
    </li>
  <li>
    Removed Mudblazor and Installed Sass for Custom design system
  </li>
   <li>
     Setup Folder structure and began building design system - Color maps/  css variables
  </li>
  </ul>
  
