import React, { useState } from 'react'


const ControlledConter = () => {
    const [inputValue, setInputValue] = useState('0');
    const handleChange = (event) => {
        setInputValue(event.target.value);
    };

    return (
        <div className="">
            <div>ControlledConter</div>
            <div>
                <label htmlFor="imputfield">Enter your name:</label> <span><input type="text" value={inputValue} onChange={handleChange} id="imputfield" /></span>
                <p>you entered the name as:{inputValue}</p>
            </div>
        </div>

    )
};

export default ControlledConter







