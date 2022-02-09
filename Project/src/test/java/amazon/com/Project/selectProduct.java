package amazon.com.Project;

import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.testng.Assert;
import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.Test;

import java.time.Duration;

public class selectProduct {
	
	ChromeDriver driver;
	@BeforeTest
	public void openurl()
	{
		String chromepath = System.getProperty("user.dir")+"\\resources\\chromedriver.exe";
		System.setProperty("webdriver.chrome.driver", chromepath);
		driver = new ChromeDriver();
		driver.navigate().to("http://www.amazon.com/");
		driver.manage().window().maximize();
		//searchforelement(); 
		//selectElement();
	    //addtocart();
		
		}
	@Test (priority = 0)
	public void searchforelement() 
	{
		WebElement searchbox = driver.findElement(By.xpath("//input[@id='twotabsearchtextbox']"));
		searchbox.sendKeys("bags");
		searchbox.submit();
		//selectElement();
		//addtocart();
	}
	
	@Test (priority = 1)
	public void selectElement()
	{
		//JavascriptExecutor js = (JavascriptExecutor) driver;
		//js.executeScript("window.scrollBy(0,300)", "");
		driver.manage().timeouts().implicitlyWait(Duration.ofSeconds(15));
		WebElement selectitem = driver.findElement(By.xpath("//*[@id=\"search\"]/div[1]/div[1]/div/span[3]/div[2]/div[3]/div/div/div/div/div[2]/div[1]/h2/a/span"));
		selectitem.click();  
	}
	
	@Test  (priority = 2)
	public void addtocart() {
		
		WebElement addItem = driver.findElement(By.xpath("//input[@id='add-to-cart-button']"));
		addItem.click(); 
	}
	
	@Test (priority = 3)
	public void opencart() {
		
		WebElement carrt = driver.findElement(By.xpath("//body/div[4]/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[3]/form[1]/span[1]/span[1]/input[1]"));
		carrt.click(); 
		WebDriverWait wait = new WebDriverWait(driver, 10);
		wait.until(ExpectedConditions.visibilityOfElementLocated(By.xpath("//h1[contains(text(),'Shopping Cart')]")));
	}
     
	@Test (priority = 4)
	public void deleteitem() {
		WebElement removeitem = driver.findElement(By.xpath("//body/div[@id='a-page']/div[2]/div[3]/div[4]/div[1]/div[2]/div[1]/div[1]/form[1]/div[2]/div[3]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/span[2]/span[1]/input[1]"));
		removeitem.click();
		
		WebElement textmessage = driver.findElement(By.xpath("//h1[contains(text(),'Your Amazon Cart is empty.')]"));
		System.out.println(textmessage.getText());
		Assert.assertTrue(textmessage.getText().contains("Your Amazon Cart is empty."));
	}
	
	@AfterTest
	public void closebrowser() {
		driver.quit();
	}
}
