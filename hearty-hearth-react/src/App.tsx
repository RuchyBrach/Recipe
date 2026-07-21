import Navbar from './Navbar'
import Sidebar from './Sidebar'
import MainScreen from './MainScreen'
import './assets/css/bootstrap.min.css'

function App() {

  return (
    <div className='container'>
      <div className="row">
        <div className="col-12 px-0">
          <Navbar />
        </div>
      </div>

      <div className="row">
        <div className="col-3 col-lg-2 border border-light">
          <Sidebar />
        </div>
        <div className="col-9 col-lg-10">
          <MainScreen />
        </div>
      </div>



    </div>
  )
}

export default App
