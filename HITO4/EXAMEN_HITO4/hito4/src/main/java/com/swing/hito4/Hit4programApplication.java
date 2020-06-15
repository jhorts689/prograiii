package com.swing.hito4;

import com.swing.hito4.service.DataService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.builder.SpringApplicationBuilder;

import javax.annotation.PostConstruct;

@SpringBootApplication
public class Hit4programApplication {
	@Autowired
	private DataService dataService;

	public static void main(String[] args) {
		//SpringApplication.run(SwingApplication.class, args);
		SpringApplicationBuilder springApp = new SpringApplicationBuilder(Hit4programApplication.class);
		springApp.headless(false);
		springApp.run(args);
	}
	@PostConstruct
	public void init(){
		dataService.saveData();
	}
}
