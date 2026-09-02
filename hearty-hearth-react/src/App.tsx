import Navbar from './Navbar'
import './assets/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import { Outlet } from 'react-router-dom'

function App() {

  return (
    <div className='container'>
      <div className="row">
        <div className="col-12 px-0">
          <Navbar />
          <Outlet></Outlet>
        </div>
      </div>


    </div>
  )
}

export default App
