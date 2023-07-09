import React, { useState, useEffect } from 'react'

const Hooksexample = () => {
    const  [count , setcount]=useState(0);
    const [data,setdata]=useState(null);
    const incrementcount =() =>{
        setcount(prevecount => prevecount+1);
    }
    useEffect(()=>
    {
        fetchData();
    },
    [count]
    );

    const fetchData =() =>{
        setTimeout(()=>{
            const newdata = `data for count${count}`;
            setdata(newdata);
        },
        3000
        );
    };

    return (
        <div>Hooksexample
            <p>count:{count }</p>
            <button onClick={incrementcount}> hooks button</button>
            <p>{data?data:"fetching.."}</p>

        </div>
    )
}

export default Hooksexample