import React from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { decrement, increment } from '../StoreManagement/reducer';

const componet = () => {
    const counter = useSelector((state) => state.counter);
    const dispatch = useDispatch();

    const incrementcounter = () =>{
        dispatch(increment());
    }
    const decrementcounter =() =>{
        dispatch(decrement());
    }
  return (
    <div>componet
        <p>Counter{counter}:</p>
        <button onClick={incrementcounter}>Increment</button>
        <button onClick={decrementcounter}>Decrement</button>

    </div>
  )
}

export default componet