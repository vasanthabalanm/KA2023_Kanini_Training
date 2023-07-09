import React,{useState,useEffect} from 'react'

const Hooksmessage = () => {

    const  [name , setname]=useState('');
    const [message,setmessage]=useState('');

    const handlechange =(event) =>{
        setname(event.target.value);
    };

    const hadlebutn =() =>{
        setmessage(`hello man${name}`);
    };

    useEffect(()=>{
        document.title=`hello man${name}`;
    },
    [name]
    );



  return (
    <div>Hooksmessage
        <form action="">
            <label htmlFor="">enter your name:</label>
            <input type="text" value={name} onChange={handlechange} />
            <button onClick={hadlebutn}>click</button>
            <p>{message}</p>
        </form>


    </div>
  )
}

export default Hooksmessage