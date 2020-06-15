package com.swing.hito4.Gui.Panels;

import org.springframework.stereotype.Component;

import javax.swing.*;
import java.awt.*;

@Component
public class EmptyPanel extends JPanel {
    public EmptyPanel(){
        this.setPreferredSize(new Dimension(500,100));
        this.setBackground(Color.cyan);
        this.setLayout(new GridLayout(2,1));

    }

}
