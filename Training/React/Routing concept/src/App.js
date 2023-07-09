import './App.css';
import {BrowserRouter,Routes,Route,Link, useNavigate} from "react-router-dom"
import Home from './navigation/Home';
import About from './navigation/About';
import Contact from './navigation/contact';
import User from './navigation/User';
import { useState } from 'react';
import StudentCRUD from './navigation/StudentCRUD';
import StudentCRUDPromise from './navigation/StudentCRUDPromise';

const App=()=> {

  
  return (
    <div>
      <BrowserRouter>
        <Mainapp/>
        <StudentCRUD/>
      </BrowserRouter>
    </div>
  );
}

const Mainapp = () =>{
  const [id,setid]=useState('');
  const navigate = useNavigate();

  const sendid = (event) =>{
    setid(event.target.value);
  };
  const handlenavigation = ()=>{
    navigate(`/user/${id}`);
  };
  return (
    <div>
        <div>
          <nav>
            <ul>
              <li>
                <Link to="/">Home</Link>
              </li>
              <li>
                <Link to="About">About</Link>
              </li>
              <li>
                <Link to="contact">Contact</Link>
              </li>
            </ul>
          </nav>

            <input type = "text" value ={id} onChange={sendid}></input>
            <button type = "button" onClick = {handlenavigation}>send</button>

          <hr></hr>
          <Routes>
            <Route exact path ='/' element={<Home/>}/>
            <Route exact path ='About' element={<About/>}/>
            <Route exact path ='contact' element={<Contact/>}/>
            <Route exact path ='/user/:id' element={<User/>}/>
          </Routes>
        </div>
      
    </div>
  );
}

export default App;
