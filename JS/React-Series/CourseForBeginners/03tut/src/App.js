import './App.css';
import Header from './Header';
import Content from './Content';
import Footer from './Footer';
import Search from './Search';
import {useState,useEffect} from 'react';

function App() {
  const [items, setItems] = useState([]);
  const [newItem,setNewItem] =useState('');
  const [search, setSearch] = useState('');

  useEffect(() =>{
    const fetchItems = async () => {
      try {
        const res = await fetch(API_URL);
      }
      catch (err){
        console.log(err);
      }
    }
  },[items,setItems]);
const setAndSaveItems = (newItems)=>{
  setItems(newItems);
}
const addItem = (item)=>{
  const id = items.length ? items[items.length - 1].id + 1: 1;
  const myNewItem = {id, checked:false; item};
  const listItems = {...items, myNewItem};
  setAndSaveItems(listItems);

}
const handleCheck = (id) =>{
    const listItems = items.map((item) => item.id === id ? {...item,checked: !item.checked} : item);
    setItems(listItems);
    localStorage.setItem('shoppinglist', JSON.stringify(listItems));
}

const handleDelete = (id) => {
    const listItems = items.filter((item) => item.id !== id);
    setItems(listItems);
    localStorage.setItem('shoppinglist', JSON.stringify(listItems));
}
const handleSubmit =(e)=>{
  e.preventDefault();
  if(!newItem) return;
  addItem(newItem);
  setNewItem('');
}
  return (
    <div className="App">
      <Header title="NDTPINE" />
      <Search 
        search={search}
        setSearch ={setSearch}        
        />
      <Content 
        items ={items.filter(item => ((item.item).toLowerCase()).includes(search.toLowerCase()))}
        handleCheck ={handleCheck}
        handleDelete={handleDelete}
      />
      <Footer length={items.length}/>
    </div>
  );
}

export default App;
